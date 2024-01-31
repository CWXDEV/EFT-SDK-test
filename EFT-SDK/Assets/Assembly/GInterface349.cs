using System;
using Newtonsoft.Json;

// Token: 0x020026E8 RID: 9960
public interface GInterface349 : GInterface348
{
	// Token: 0x1700234B RID: 9035
	// (get) Token: 0x0600C570 RID: 50544
	// (set) Token: 0x0600C571 RID: 50545
	[JsonIgnore]
	bool IsUpdated { get; set; }

	// Token: 0x0600C572 RID: 50546
	void Serialize(ref GInterface79 writerStream, bool isFullUpdate = false);

	// Token: 0x0600C573 RID: 50547
	void Deserialize(ref GInterface76 readerStream);
}
