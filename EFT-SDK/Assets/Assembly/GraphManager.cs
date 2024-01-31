using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020000EA RID: 234
public class GraphManager : MonoBehaviour
{
	// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool smethod_0()
	{
		throw null;
	}

	// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawRectangle(Vector4 rect, bool isWorldSpace, Matrix4x4 trs, bool invertCoordinate)
	{
		throw null;
	}

	// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void DrawLine(Vector3 A, Vector3 B, bool invertCoordinate)
	{
		throw null;
	}

	// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1(Material material, bool isWorldSpace)
	{
		throw null;
	}

	// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_2()
	{
		throw null;
	}

	// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static GameObject smethod_3()
	{
		throw null;
	}

	// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Start()
	{
		throw null;
	}

	// Token: 0x060004E2 RID: 1250 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void Update()
	{
		throw null;
	}

	// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void method_0()
	{
		throw null;
	}

	// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void SaveCurrentResults(string filePath)
	{
		throw null;
	}

	// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void OnRenderObject()
	{
		throw null;
	}

	// Token: 0x0400061F RID: 1567
	public static GraphManager.GClass11 Graph;

	// Token: 0x04000620 RID: 1568
	public static GameObject GraphManagerUI;

	// Token: 0x04000621 RID: 1569
	public static GameObject GraphsUI;

	// Token: 0x04000622 RID: 1570
	private Material material_0;

	// Token: 0x020000EB RID: 235
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct0
	{
		// Token: 0x04000623 RID: 1571
		public Vector3 Translation;

		// Token: 0x04000624 RID: 1572
		public Quaternion Rotation;

		// Token: 0x04000625 RID: 1573
		public Vector3 Scale;

		// Token: 0x04000626 RID: 1574
		public Matrix4x4 TRS;
	}

	// Token: 0x020000EC RID: 236
	[StructLayout(LayoutKind.Auto)]
	public struct GStruct1
	{
		// Token: 0x17000193 RID: 403
		// (get) Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		public float Value
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		public Color Color
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		public bool Mark
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		public Color MarkColor
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x04000627 RID: 1575
		[CompilerGenerated]
		private float float_0;

		// Token: 0x04000628 RID: 1576
		[CompilerGenerated]
		private Color color_0;

		// Token: 0x04000629 RID: 1577
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400062A RID: 1578
		[CompilerGenerated]
		private Color color_1;
	}

	// Token: 0x020000ED RID: 237
	public class GClass10
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060004EE RID: 1262 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004EF RID: 1263 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsWorldSpace
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F1 RID: 1265 RVA: 0x00002050 File Offset: 0x00000250
		public GraphManager.GStruct0 TRS
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F3 RID: 1267 RVA: 0x00002050 File Offset: 0x00000250
		public int MaxNumPoints
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060004F4 RID: 1268 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F5 RID: 1269 RVA: 0x00002050 File Offset: 0x00000250
		public float MinValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060004F6 RID: 1270 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F7 RID: 1271 RVA: 0x00002050 File Offset: 0x00000250
		public float MaxValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004F9 RID: 1273 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoMaxValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x00002050 File Offset: 0x00000250
		public bool AutoMinValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x00002050 File Offset: 0x00000250
		public float AverageValue
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x00002050 File Offset: 0x00000250
		public float CurrentRange
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		public Vector4 Rectangle
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetDefault()
		{
			throw null;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetUI()
		{
			throw null;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateStats(float dataPoint)
		{
			throw null;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InitializeParentUI()
		{
			throw null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateUI()
		{
			throw null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint)
		{
			throw null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint, Color color)
		{
			throw null;
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint, Color color, Rect rectangle)
		{
			throw null;
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint, Color color, bool mark, Color markColor, Rect rectangle)
		{
			throw null;
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0(GraphManager.GStruct1 dataPair, Rect rectangle)
		{
			throw null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint, GraphManager.GStruct0 trs)
		{
			throw null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddPair(float dataPoint, Color color, GraphManager.GStruct0 trs)
		{
			throw null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Shrink()
		{
			throw null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetX(int index, float offset)
		{
			throw null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public float GetY(int index)
		{
			throw null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Render(Material graphMaterial)
		{
			throw null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector3 method_1(Vector3 pos)
		{
			throw null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateText()
		{
			throw null;
		}

		// Token: 0x0400062B RID: 1579
		public GameObject ParentUI;

		// Token: 0x0400062C RID: 1580
		public List<GraphManager.GStruct1> DataPairs;

		// Token: 0x0400062D RID: 1581
		public string Name;

		// Token: 0x0400062E RID: 1582
		public GameObject CanvasUI;

		// Token: 0x0400062F RID: 1583
		public Canvas Canvas;

		// Token: 0x04000630 RID: 1584
		public RectTransform CanvasRect;

		// Token: 0x04000631 RID: 1585
		public GameObject MaxUI;

		// Token: 0x04000632 RID: 1586
		public GameObject MinUI;

		// Token: 0x04000633 RID: 1587
		public GameObject AvgUI;

		// Token: 0x04000634 RID: 1588
		public Text MaxText;

		// Token: 0x04000635 RID: 1589
		public Text MinText;

		// Token: 0x04000636 RID: 1590
		public Text AvgText;

		// Token: 0x04000637 RID: 1591
		public RectTransform MaxTransform;

		// Token: 0x04000638 RID: 1592
		public RectTransform AvgTransform;

		// Token: 0x04000639 RID: 1593
		public RectTransform MinTransform;

		// Token: 0x0400063A RID: 1594
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400063B RID: 1595
		[CompilerGenerated]
		private GraphManager.GStruct0 gstruct0_0;

		// Token: 0x0400063C RID: 1596
		[CompilerGenerated]
		private int int_0;

		// Token: 0x0400063D RID: 1597
		private int int_1;

		// Token: 0x0400063E RID: 1598
		[CompilerGenerated]
		private float float_0;

		// Token: 0x0400063F RID: 1599
		[CompilerGenerated]
		private float float_1;

		// Token: 0x04000640 RID: 1600
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x04000641 RID: 1601
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x04000642 RID: 1602
		[CompilerGenerated]
		private float float_2;

		// Token: 0x04000643 RID: 1603
		[CompilerGenerated]
		private float float_3;

		// Token: 0x04000644 RID: 1604
		[CompilerGenerated]
		private float float_4;

		// Token: 0x04000645 RID: 1605
		[CompilerGenerated]
		private Vector4 vector4_0;
	}

	// Token: 0x020000EE RID: 238
	public class GClass11
	{
		// Token: 0x06000518 RID: 1304 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public GraphManager.GClass10 Retrieve(string key, float value)
		{
			throw null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ResetAll()
		{
			throw null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool Reset(string key)
		{
			throw null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value)
		{
			throw null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value, GraphManager.GStruct0 trs)
		{
			throw null;
		}

		// Token: 0x0600051E RID: 1310 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value, Color color)
		{
			throw null;
		}

		// Token: 0x0600051F RID: 1311 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value, Color color, Rect rectangle)
		{
			throw null;
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value, Color color, bool mark, Color markColor, Rect rectangle)
		{
			throw null;
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Plot(string key, float value, Color color, GraphManager.GStruct0 trs)
		{
			throw null;
		}

		// Token: 0x04000646 RID: 1606
		public Dictionary<string, GraphManager.GClass10> Graphs;
	}
}
