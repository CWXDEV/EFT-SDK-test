using System;
using UnityEngine;

// Token: 0x02000091 RID: 145
[Serializable]
public class qb_Template
{
	// Token: 0x040002B8 RID: 696
	public bool live;

	// Token: 0x040002B9 RID: 697
	public string brushName;

	// Token: 0x040002BA RID: 698
	public float brushRadius;

	// Token: 0x040002BB RID: 699
	public float brushRadiusMin;

	// Token: 0x040002BC RID: 700
	public float brushRadiusMax;

	// Token: 0x040002BD RID: 701
	public float brushSpacing;

	// Token: 0x040002BE RID: 702
	public float brushSpacingMin;

	// Token: 0x040002BF RID: 703
	public float brushSpacingMax;

	// Token: 0x040002C0 RID: 704
	public float scatterRadius;

	// Token: 0x040002C1 RID: 705
	public bool alignToNormal;

	// Token: 0x040002C2 RID: 706
	public bool flipNormalAlign;

	// Token: 0x040002C3 RID: 707
	public bool alignToStroke;

	// Token: 0x040002C4 RID: 708
	public bool flipStrokeAlign;

	// Token: 0x040002C5 RID: 709
	public Vector3 rotationRangeMin;

	// Token: 0x040002C6 RID: 710
	public Vector3 rotationRangeMax;

	// Token: 0x040002C7 RID: 711
	public Vector3 positionOffset;

	// Token: 0x040002C8 RID: 712
	public float scaleMin;

	// Token: 0x040002C9 RID: 713
	public float scaleMax;

	// Token: 0x040002CA RID: 714
	public Vector3 scaleRandMin;

	// Token: 0x040002CB RID: 715
	public Vector3 scaleRandMax;

	// Token: 0x040002CC RID: 716
	public float scaleRandMinUniform;

	// Token: 0x040002CD RID: 717
	public float scaleRandMaxUniform;

	// Token: 0x040002CE RID: 718
	public bool scaleUniform;

	// Token: 0x040002CF RID: 719
	public bool paintToSelection;

	// Token: 0x040002D0 RID: 720
	public bool paintToLayer;

	// Token: 0x040002D1 RID: 721
	public int layerIndex;

	// Token: 0x040002D2 RID: 722
	public bool groupObjects;

	// Token: 0x040002D3 RID: 723
	public int groupIndex;

	// Token: 0x040002D4 RID: 724
	public bool eraseByGroup;

	// Token: 0x040002D5 RID: 725
	public bool eraseBySelected;

	// Token: 0x040002D6 RID: 726
	public qb_PrefabObject[] prefabGroup;

	// Token: 0x040002D7 RID: 727
	public bool dirty;
}
