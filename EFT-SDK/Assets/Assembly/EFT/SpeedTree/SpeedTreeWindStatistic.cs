using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace EFT.SpeedTree
{
	// Token: 0x02001DAB RID: 7595
	public class SpeedTreeWindStatistic : MonoBehaviour
	{
		// Token: 0x17001890 RID: 6288
		// (get) Token: 0x06009C82 RID: 40066 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009C83 RID: 40067 RVA: 0x00002050 File Offset: 0x00000250
		public TreeWind.BaseTreeData BaseMinWindData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001891 RID: 6289
		// (get) Token: 0x06009C84 RID: 40068 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009C85 RID: 40069 RVA: 0x00002050 File Offset: 0x00000250
		public TreeWind.BaseTreeData BaseMaxWindData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001892 RID: 6290
		// (get) Token: 0x06009C86 RID: 40070 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009C87 RID: 40071 RVA: 0x00002050 File Offset: 0x00000250
		public TreeWind.FactorTreeData MinWindData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001893 RID: 6291
		// (get) Token: 0x06009C88 RID: 40072 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06009C89 RID: 40073 RVA: 0x00002050 File Offset: 0x00000250
		public TreeWind.FactorTreeData MaxWindData
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RecordTick()
		{
			throw null;
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveAsMinWindData()
		{
			throw null;
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SaveAsMaxWindData()
		{
			throw null;
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TreeWind.BaseTreeData method_0()
		{
			throw null;
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private TreeWind.FactorTreeData method_1()
		{
			throw null;
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2()
		{
			throw null;
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ExportToFile(string path)
		{
			throw null;
		}

		// Token: 0x06009C91 RID: 40081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(StreamWriter writer, List<Vector4> data, string varName)
		{
			throw null;
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_4()
		{
			throw null;
		}

		// Token: 0x06009C93 RID: 40083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Vector4 method_5(Vector4 vec)
		{
			throw null;
		}

		// Token: 0x06009C94 RID: 40084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearStatisticData()
		{
			throw null;
		}

		// Token: 0x0400A3C8 RID: 41928
		[CompilerGenerated]
		private TreeWind.BaseTreeData baseTreeData_0;

		// Token: 0x0400A3C9 RID: 41929
		[CompilerGenerated]
		private TreeWind.BaseTreeData baseTreeData_1;

		// Token: 0x0400A3CA RID: 41930
		[CompilerGenerated]
		private TreeWind.FactorTreeData factorTreeData_0;

		// Token: 0x0400A3CB RID: 41931
		[CompilerGenerated]
		private TreeWind.FactorTreeData factorTreeData_1;

		// Token: 0x0400A3CC RID: 41932
		private List<Vector4> list_0;

		// Token: 0x0400A3CD RID: 41933
		private List<Vector4> list_1;

		// Token: 0x0400A3CE RID: 41934
		private List<Vector4> list_2;

		// Token: 0x0400A3CF RID: 41935
		private List<Vector4> list_3;

		// Token: 0x0400A3D0 RID: 41936
		private List<Vector4> list_4;

		// Token: 0x0400A3D1 RID: 41937
		private List<Vector4> list_5;

		// Token: 0x0400A3D2 RID: 41938
		private List<Vector4> list_6;

		// Token: 0x0400A3D3 RID: 41939
		private List<Vector4> list_7;

		// Token: 0x0400A3D4 RID: 41940
		private List<Vector4> list_8;

		// Token: 0x0400A3D5 RID: 41941
		private List<Vector4> list_9;

		// Token: 0x0400A3D6 RID: 41942
		private List<Vector4> list_10;

		// Token: 0x0400A3D7 RID: 41943
		private List<Vector4> list_11;

		// Token: 0x0400A3D8 RID: 41944
		private List<Vector4> list_12;

		// Token: 0x0400A3D9 RID: 41945
		private List<Vector4> list_13;

		// Token: 0x0400A3DA RID: 41946
		private List<Vector4> list_14;

		// Token: 0x0400A3DB RID: 41947
		private List<float> list_15;

		// Token: 0x0400A3DC RID: 41948
		private MaterialPropertyBlock materialPropertyBlock_0;

		// Token: 0x0400A3DD RID: 41949
		private Renderer renderer_0;
	}
}
