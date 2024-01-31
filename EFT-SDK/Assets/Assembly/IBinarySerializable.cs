using System;
using System.IO;

// Token: 0x02000838 RID: 2104
public interface IBinarySerializable
{
	// Token: 0x0600301F RID: 12319
	void Write(BinaryWriter writer);

	// Token: 0x06003020 RID: 12320
	void Read(BinaryReader reader);
}
