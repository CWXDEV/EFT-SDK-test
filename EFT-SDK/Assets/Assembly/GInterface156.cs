using System;
using EFT.InputSystem;

// Token: 0x02001A3C RID: 6716
public interface GInterface156
{
	// Token: 0x17001590 RID: 5520
	// (get) Token: 0x06008E31 RID: 36401
	// (set) Token: 0x06008E32 RID: 36402
	bool ReleaseNextFrame { get; set; }

	// Token: 0x17001591 RID: 5521
	// (get) Token: 0x06008E33 RID: 36403
	bool IsAxis { get; }

	// Token: 0x06008E34 RID: 36404
	float GetValue();

	// Token: 0x17001592 RID: 5522
	// (get) Token: 0x06008E35 RID: 36405
	// (set) Token: 0x06008E36 RID: 36406
	GClass1890 InUseBy { get; set; }

	// Token: 0x17001593 RID: 5523
	// (get) Token: 0x06008E37 RID: 36407
	// (set) Token: 0x06008E38 RID: 36408
	EKeyPress Press { get; set; }
}
