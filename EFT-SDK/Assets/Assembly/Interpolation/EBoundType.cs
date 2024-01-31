using System;

namespace Interpolation
{
	// Token: 0x02000F2C RID: 3884
	[Flags]
	public enum EBoundType
	{
		// Token: 0x04005D68 RID: 23912
		Unknown = 0,
		// Token: 0x04005D69 RID: 23913
		Less = 1,
		// Token: 0x04005D6A RID: 23914
		LessOrEqual = 3,
		// Token: 0x04005D6B RID: 23915
		Equals = 6,
		// Token: 0x04005D6C RID: 23916
		GreaterOrEqual = 13,
		// Token: 0x04005D6D RID: 23917
		Greater = 27
	}
}
