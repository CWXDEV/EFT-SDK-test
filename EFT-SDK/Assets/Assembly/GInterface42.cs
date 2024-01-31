using System;
using UnityEngine;

// Token: 0x02000BB4 RID: 2996
public interface GInterface42
{
	// Token: 0x060040F7 RID: 16631
	void CustomUpdate();

	// Token: 0x060040F8 RID: 16632
	void Register();

	// Token: 0x17000A81 RID: 2689
	// (get) Token: 0x060040F9 RID: 16633
	float Radius { get; }

	// Token: 0x17000A82 RID: 2690
	// (get) Token: 0x060040FA RID: 16634
	Vector3 Position { get; }

	// Token: 0x17000A83 RID: 2691
	// (get) Token: 0x060040FB RID: 16635
	Vector3 ClearTransformPosition { get; }

	// Token: 0x17000A84 RID: 2692
	// (get) Token: 0x060040FC RID: 16636
	Vector3 SafeMultithreadedPosition { get; }

	// Token: 0x17000A85 RID: 2693
	// (get) Token: 0x060040FD RID: 16637
	bool IsAutocullVisible { get; }

	// Token: 0x17000A86 RID: 2694
	// (get) Token: 0x060040FE RID: 16638
	int Index { get; }

	// Token: 0x17000A87 RID: 2695
	// (get) Token: 0x060040FF RID: 16639
	float CullDistanceSqr { get; }

	// Token: 0x17000A88 RID: 2696
	// (get) Token: 0x06004100 RID: 16640
	// (set) Token: 0x06004101 RID: 16641
	bool CullByDistanceOnly { get; set; }

	// Token: 0x06004102 RID: 16642
	void SetVisibility(bool isVisible);

	// Token: 0x17000A89 RID: 2697
	// (get) Token: 0x06004103 RID: 16643
	// (set) Token: 0x06004104 RID: 16644
	float SqrCameraDistance { get; set; }

	// Token: 0x17000A8A RID: 2698
	// (get) Token: 0x06004105 RID: 16645
	bool IsVisible { get; }

	// Token: 0x17000A8B RID: 2699
	// (get) Token: 0x06004106 RID: 16646
	// (set) Token: 0x06004107 RID: 16647
	bool IsVisibleByCamera { get; set; }
}
