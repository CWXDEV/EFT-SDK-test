using System;
using System.Collections.Generic;
using ChartAndGraph;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02003181 RID: 12673
internal interface Interface21
{
	// Token: 0x17002B2B RID: 11051
	// (get) Token: 0x0600F9A8 RID: 63912
	List<BillboardText> TextObjects { get; }

	// Token: 0x17002B2C RID: 11052
	// (get) Token: 0x0600F9A9 RID: 63913
	// (set) Token: 0x0600F9AA RID: 63914
	float Tile { get; set; }

	// Token: 0x17002B2D RID: 11053
	// (get) Token: 0x0600F9AB RID: 63915
	// (set) Token: 0x0600F9AC RID: 63916
	float Offset { get; set; }

	// Token: 0x17002B2E RID: 11054
	// (get) Token: 0x0600F9AD RID: 63917
	// (set) Token: 0x0600F9AE RID: 63918
	float Length { get; set; }

	// Token: 0x0600F9AF RID: 63919
	[CanBeNull]
	BillboardText AddText(AnyChart chart, Text prefab, Transform parentTransform, int fontSize, float fontScale, string text, float x, float y, float z, float angle, object userData);

	// Token: 0x0600F9B0 RID: 63920
	void AddYZRect(Rect rect, int subMeshGroup, float xPosition);

	// Token: 0x0600F9B1 RID: 63921
	void AddXZRect(Rect rect, int subMeshGroup, float yPosition);

	// Token: 0x0600F9B2 RID: 63922
	void AddXYRect(Rect rect, int subMeshGroup, float depth);

	// Token: 0x0600F9B3 RID: 63923
	void AddQuad(UIVertex vLeftTop, UIVertex vRightTop, UIVertex vLeftBottom, UIVertex vRightBottom);
}
