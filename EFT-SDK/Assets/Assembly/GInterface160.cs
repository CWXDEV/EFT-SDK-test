using System;

// Token: 0x02001AA2 RID: 6818
public interface GInterface160 : GInterface168
{
	// Token: 0x1400019F RID: 415
	// (add) Token: 0x06008FA3 RID: 36771
	// (remove) Token: 0x06008FA4 RID: 36772
	event Action<GInterface160, bool> OnWorkingStateChanged;

	// Token: 0x170015C0 RID: 5568
	// (get) Token: 0x06008FA5 RID: 36773
	bool IsWorking { get; }

	// Token: 0x06008FA6 RID: 36774
	bool Work(float deltaTime);

	// Token: 0x06008FA7 RID: 36775
	void SetSwitchedStatus(bool isOn);
}
