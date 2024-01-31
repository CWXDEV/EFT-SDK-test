using System;

namespace EFT
{
	// Token: 0x020011A8 RID: 4520
	public enum EDisconnectionCode
	{
		// Token: 0x04006A34 RID: 27188
		Unknown,
		// Token: 0x04006A35 RID: 27189
		SABER_ANTICHEAT_AnticheatConnectionFailed,
		// Token: 0x04006A36 RID: 27190
		BATTLEYE_ANTICHEAT_ClientNotResponding,
		// Token: 0x04006A37 RID: 27191
		BATTLEYE_ANTICHEAT_QueryTimeout,
		// Token: 0x04006A38 RID: 27192
		BATTLEYE_ANTICHEAT_GameRestartRequired,
		// Token: 0x04006A39 RID: 27193
		BATTLEYE_ANTICHEAT_BadServiceVersion,
		// Token: 0x04006A3A RID: 27194
		BATTLEYE_ANTICHEAT_DisallowedProgram,
		// Token: 0x04006A3B RID: 27195
		BATTLEYE_ANTICHEAT_CorruptedMemory,
		// Token: 0x04006A3C RID: 27196
		BATTLEYE_ANTICHEAT_CorruptedData,
		// Token: 0x04006A3D RID: 27197
		BATTLEYE_ANTICHEAT_WinAPIFailure,
		// Token: 0x04006A3E RID: 27198
		BATTLEYE_ANTICHEAT_GlobalBan,
		// Token: 0x04006A3F RID: 27199
		BAD_RTT,
		// Token: 0x04006A40 RID: 27200
		HIGH_PACKETS_LOSS,
		// Token: 0x04006A41 RID: 27201
		TIME_MISMATCH
	}
}
