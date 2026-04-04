using System;
using System.Collections.Generic;
using UnityEngine;

namespace AutoLetterbox
{
	// Token: 0x020000C6 RID: 198
	public class TerrainSegment : MonoBehaviour
	{
		// Token: 0x060005BD RID: 1469 RVA: 0x00068F5E File Offset: 0x0006715E
		private void Awake()
		{
			this.Setup(this.numberOfPoints, true, 0f);
			this.RecalculateTerrainFromCurve();
		}

		// Token: 0x060005BE RID: 1470 RVA: 0x00068F78 File Offset: 0x00067178
		private void CalculateUVsAndVerts(List<Vector3> newVertices)
		{
			Vector2 vector = new Vector2(1f, 1f);
			if (this.meshRenderer.sharedMaterial != null && this.meshRenderer.sharedMaterial.mainTexture != null)
			{
				vector.x = (float)this.pixelsPerUnit / (float)this.meshRenderer.sharedMaterial.mainTexture.width;
				vector.y = (float)this.pixelsPerUnit / (float)this.meshRenderer.sharedMaterial.mainTexture.height;
			}
			if (this.uvMode == UVMappingMode.STRETCH_MATCH)
			{
				float x = 0f;
				for (int i = 0; i < newVertices.Count; i++)
				{
					this.vertices[i] = newVertices[i];
					if (newVertices[i].y == this.baseDepthOfTerrain)
					{
						this.uvs[i] = new Vector2(x, 0f);
					}
					else
					{
						x = Util.Percent(0f, (float)(newVertices.Count - 2), (float)i);
						this.uvs[i] = new Vector2(x, 1f);
					}
				}
			}
			else if (this.uvMode == UVMappingMode.TILING)
			{
				if (this.meshRenderer.sharedMaterial != null && this.meshRenderer.sharedMaterial.mainTexture != null)
				{
					vector.x = (float)this.pixelsPerUnit / (float)this.meshRenderer.sharedMaterial.mainTexture.width;
					vector.y = (float)this.pixelsPerUnit / (float)this.meshRenderer.sharedMaterial.mainTexture.height;
				}
				for (int j = 0; j < newVertices.Count; j++)
				{
					this.vertices[j] = newVertices[j];
					this.uvs[j] = new Vector2(newVertices[j].x * vector.x, newVertices[j].y * vector.y);
				}
			}
			for (int k = 0; k < newVertices.Count; k++)
			{
				this.trimVertices[k] = newVertices[k];
				if (newVertices[k].y == this.baseDepthOfTerrain && k - 1 >= 0)
				{
					this.trimVertices[k].y = newVertices[k - 1].y - 1f / vector.y;
					this.trimUvs[k] = new Vector2(newVertices[k].x * vector.x, 0f);
				}
				else
				{
					this.trimUvs[k] = new Vector2(newVertices[k].x * vector.x, 1f);
				}
			}
		}

		// Token: 0x060005BF RID: 1471 RVA: 0x00069250 File Offset: 0x00067450
		public void Setup(int numberOfPoints, bool createEdge, float startingY)
		{
			this.numberOfPoints = numberOfPoints;
			if (this.terrainDescription.keys.Length < 2)
			{
				this.terrainDescription.AddKey(0f, 0f);
				this.terrainDescription.AddKey(1f, 0f);
			}
			this.curveLength = this.terrainDescription.keys[this.terrainDescription.keys.Length - 1].time - this.terrainDescription.keys[0].time;
			this.length = this.curveLength * this.unitScale;
			this.createEdge = createEdge;
			this.edgeCollider = base.gameObject.GetComponent<EdgeCollider2D>();
			if (this.mesh != null)
			{
				Object.DestroyImmediate(this.mesh);
			}
			this.mesh = new Mesh();
			this.mesh.name = "Terrain Mesh";
			base.GetComponent<MeshFilter>().mesh = this.mesh;
			this.meshRenderer = base.GetComponent<MeshRenderer>();
			this.verticeXspacing = this.length / (float)numberOfPoints;
			Transform transform = base.transform.Find(this.trimName);
			GameObject gameObject;
			if (transform == null)
			{
				gameObject = new GameObject(this.trimName);
				gameObject.transform.parent = base.transform;
				gameObject.transform.localPosition = Vector3.zero;
				gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
				gameObject.transform.localRotation = default(Quaternion);
				gameObject.AddComponent<MeshFilter>();
				gameObject.AddComponent<MeshRenderer>();
			}
			else
			{
				gameObject = transform.gameObject;
			}
			if (this.trimMesh != null)
			{
				Object.DestroyImmediate(this.trimMesh);
			}
			this.trimMesh = new Mesh();
			this.trimMesh.name = "Terrain Trim Mesh";
			gameObject.GetComponent<MeshFilter>().mesh = this.trimMesh;
			this.trimMeshRenderer = gameObject.GetComponent<MeshRenderer>();
			this.GenerateLandSegment(startingY);
		}

		// Token: 0x060005C0 RID: 1472 RVA: 0x00069458 File Offset: 0x00067658
		public void RecalculateTerrainFromCurve()
		{
			List<Vector3> list = new List<Vector3>();
			if (this.terrainDescription.keys.Length < 2)
			{
				this.terrainDescription.AddKey(0f, 0f);
				this.terrainDescription.AddKey(1f, 0f);
			}
			this.curveLength = this.terrainDescription.keys[this.terrainDescription.keys.Length - 1].time - this.terrainDescription.keys[0].time;
			this.length = this.curveLength * this.unitScale;
			for (int i = 0; i < this.numberOfPoints; i++)
			{
				float num = Util.Percent(0f, (float)(this.numberOfPoints - 1), (float)i);
				list.Add(new Vector3(this.length * num, this.terrainDescription.Evaluate(Util.Lerp(this.terrainDescription.keys[0].time, this.curveLength, num)) * this.maxHeight, 0f));
			}
			this.BuildHills(list);
		}

		// Token: 0x060005C1 RID: 1473 RVA: 0x00069578 File Offset: 0x00067778
		public void BuildHills(List<Vector3> peaks)
		{
			this.peakVertices = peaks;
			List<Vector3> list = new List<Vector3>();
			for (int i = 0; i < this.peakVertices.Count; i++)
			{
				list.Add(this.peakVertices[i]);
				list.Add(new Vector3(this.peakVertices[i].x, this.baseDepthOfTerrain, 0f));
			}
			this.vertices = new Vector3[list.Count];
			this.uvs = new Vector2[list.Count];
			this.trimVertices = new Vector3[list.Count];
			this.trimUvs = new Vector2[list.Count];
			this.CalculateUVsAndVerts(list);
			this.mesh.vertices = this.vertices;
			this.mesh.uv = this.uvs;
			this.mesh.triangles = this.triangles;
			this.mesh.RecalculateBounds();
			this.mesh.RecalculateNormals();
			this.trimMesh.vertices = this.trimVertices;
			this.trimMesh.uv = this.trimUvs;
			this.trimMesh.triangles = this.triangles;
			this.trimMesh.RecalculateBounds();
			this.trimMesh.RecalculateNormals();
			this.trimMeshRenderer.transform.localPosition = new Vector3(0f, this.trimOffset, -0.01f);
			if (this.createEdge)
			{
				this.edgeCollider.points = this.GetEdge();
			}
		}

		// Token: 0x060005C2 RID: 1474 RVA: 0x000696FC File Offset: 0x000678FC
		public void GenerateLandSegment(float y)
		{
			this.peakVertices = new List<Vector3>();
			this.originalPeakVertices = new List<Vector3>();
			for (int i = 0; i < this.numberOfPoints; i++)
			{
				this.peakVertices.Add(new Vector3((float)i * this.verticeXspacing, y, 0f));
				this.originalPeakVertices.Add(new Vector3((float)i * this.verticeXspacing, 1f, 0f));
			}
			List<Vector3> list = new List<Vector3>();
			for (int j = 0; j < this.numberOfPoints; j++)
			{
				list.Add(this.peakVertices[j]);
				list.Add(new Vector3(this.peakVertices[j].x, -5f, 0f));
			}
			List<int> list2 = new List<int>();
			for (int k = list.Count - 1; k > 2; k -= 2)
			{
				list2.Add(k - 3);
				list2.Add(k - 1);
				list2.Add(k);
				list2.Add(k);
				list2.Add(k - 2);
				list2.Add(k - 3);
			}
			this.vertices = new Vector3[list.Count];
			this.uvs = new Vector2[list.Count];
			this.trimVertices = new Vector3[list.Count];
			this.trimUvs = new Vector2[list.Count];
			for (int l = 0; l < list.Count; l++)
			{
				this.vertices[l] = list[l];
				if (list[l].y == 0f)
				{
					this.uvs[l] = new Vector2(list[l].x, 0f);
				}
				else
				{
					this.uvs[l] = new Vector2(list[l].x, 1f);
				}
			}
			this.triangles = new int[list2.Count];
			for (int m = 0; m < list2.Count; m++)
			{
				this.triangles[m] = list2[m];
			}
			this.mesh.vertices = this.vertices;
			this.mesh.uv = this.uvs;
			this.mesh.triangles = this.triangles;
			this.mesh.RecalculateBounds();
			this.mesh.RecalculateNormals();
			if (this.createEdge)
			{
				this.edgeCollider.points = this.GetEdge();
			}
		}

		// Token: 0x060005C3 RID: 1475 RVA: 0x00069980 File Offset: 0x00067B80
		public Vector2[] GetEdge()
		{
			Vector2[] array = new Vector2[this.peakVertices.Count];
			for (int i = 0; i < this.peakVertices.Count; i++)
			{
				array[i] = new Vector2(this.peakVertices[i].x, this.peakVertices[i].y);
			}
			return array;
		}

		// Token: 0x060005C4 RID: 1476 RVA: 0x000699E3 File Offset: 0x00067BE3
		public Vector3 GetRightVertex()
		{
			return this.peakVertices[this.peakVertices.Count - 1];
		}

		// Token: 0x060005C5 RID: 1477 RVA: 0x000699FD File Offset: 0x00067BFD
		public Mesh GetMesh()
		{
			return this.mesh;
		}

		// Token: 0x060005C6 RID: 1478 RVA: 0x00069A05 File Offset: 0x00067C05
		public Material GetTrimMaterial()
		{
			if (this.trimMeshRenderer != null)
			{
				return this.trimMeshRenderer.sharedMaterial;
			}
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00069A22 File Offset: 0x00067C22
		public Material GetMaterial()
		{
			if (this.meshRenderer != null)
			{
				return this.meshRenderer.sharedMaterial;
			}
			return null;
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x00069A3F File Offset: 0x00067C3F
		public void SetTrimMaterial(Material newMaterial)
		{
			if (this.trimMeshRenderer != null)
			{
				this.trimMeshRenderer.sharedMaterial = newMaterial;
			}
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x00069A5B File Offset: 0x00067C5B
		public void SetMaterial(Material newMaterial)
		{
			if (this.meshRenderer != null)
			{
				this.meshRenderer.sharedMaterial = newMaterial;
			}
		}

		// Token: 0x040010AA RID: 4266
		[HideInInspector]
		public int numberOfPoints = 50;

		// Token: 0x040010AB RID: 4267
		[HideInInspector]
		public float length = 27f;

		// Token: 0x040010AC RID: 4268
		[HideInInspector]
		public bool createEdge;

		// Token: 0x040010AD RID: 4269
		[HideInInspector]
		public float baseDepthOfTerrain = -5f;

		// Token: 0x040010AE RID: 4270
		[HideInInspector]
		public float maxHeight = 11f;

		// Token: 0x040010AF RID: 4271
		[HideInInspector]
		public AnimationCurve terrainDescription = new AnimationCurve();

		// Token: 0x040010B0 RID: 4272
		[HideInInspector]
		public UVMappingMode uvMode;

		// Token: 0x040010B1 RID: 4273
		[HideInInspector]
		public int pixelsPerUnit = 32;

		// Token: 0x040010B2 RID: 4274
		[HideInInspector]
		public float trimOffset = 0.1f;

		// Token: 0x040010B3 RID: 4275
		[HideInInspector]
		public float unitScale = 25f;

		// Token: 0x040010B4 RID: 4276
		private float curveLength;

		// Token: 0x040010B5 RID: 4277
		private float verticeXspacing;

		// Token: 0x040010B6 RID: 4278
		private List<Vector3> peakVertices;

		// Token: 0x040010B7 RID: 4279
		private List<Vector3> originalPeakVertices;

		// Token: 0x040010B8 RID: 4280
		private Vector3[] vertices;

		// Token: 0x040010B9 RID: 4281
		private Vector2[] uvs;

		// Token: 0x040010BA RID: 4282
		private int[] triangles;

		// Token: 0x040010BB RID: 4283
		private Mesh mesh;

		// Token: 0x040010BC RID: 4284
		private MeshRenderer meshRenderer;

		// Token: 0x040010BD RID: 4285
		private Mesh trimMesh;

		// Token: 0x040010BE RID: 4286
		private MeshRenderer trimMeshRenderer;

		// Token: 0x040010BF RID: 4287
		private Vector2[] trimUvs;

		// Token: 0x040010C0 RID: 4288
		private Vector3[] trimVertices;

		// Token: 0x040010C1 RID: 4289
		private string trimName = "TerrainTrim";

		// Token: 0x040010C2 RID: 4290
		private EdgeCollider2D edgeCollider;
	}
}
