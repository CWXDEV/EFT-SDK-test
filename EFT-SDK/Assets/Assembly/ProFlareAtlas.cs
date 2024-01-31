using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x02000ABE RID: 2750
public class ProFlareAtlas : MonoBehaviour
{
	// Token: 0x06003C31 RID: 15409 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void UpdateElementNameList()
	{
		throw null;
	}

	// Token: 0x040041B4 RID: 16820
	public Texture2D texture;

	// Token: 0x040041B5 RID: 16821
	public int elementNumber;

	// Token: 0x040041B6 RID: 16822
	public bool editElements;

	// Token: 0x040041B7 RID: 16823
	[SerializeField]
	public List<ProFlareAtlas.Element> elementsList;

	// Token: 0x040041B8 RID: 16824
	public string[] elementNameList;

	// Token: 0x02000ABF RID: 2751
	[Serializable]
	public class Element
	{
		// Token: 0x040041B9 RID: 16825
		public string name;

		// Token: 0x040041BA RID: 16826
		public Rect UV;

		// Token: 0x040041BB RID: 16827
		public bool Imported;
	}
}
