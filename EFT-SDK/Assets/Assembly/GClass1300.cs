using System;

// Token: 0x020011A2 RID: 4514
public class GClass1300
{
	// Token: 0x040069FF RID: 27135
	public const int DEFAULT_SEND_RATE_LIMIT = 100;

	// Token: 0x04006A00 RID: 27136
	public const int DEFAULT_KEEP_ALIVE_LIMIT = 60;

	// Token: 0x04006A01 RID: 27137
	public const int DEFAULT_GROUP_STATUS_LIMIT = 20;

	// Token: 0x04006A02 RID: 27138
	public const int DEFAULT_GROUP_STATUS_BUTTON_UPDATE_LIMIT = 7;

	// Token: 0x04006A03 RID: 27139
	public const int DEFAULT_PING_SERVER_RESULT_SEND_INTERVAL = 20;

	// Token: 0x04006A04 RID: 27140
	public const int DEFAULT_PING_SERVERS_INTERVAL = 5;

	// Token: 0x04006A05 RID: 27141
	public bool TurnOffLogging;

	// Token: 0x04006A06 RID: 27142
	public int ClientSendRateLimit;

	// Token: 0x04006A07 RID: 27143
	public int KeepAliveInterval;

	// Token: 0x04006A08 RID: 27144
	public int GroupStatusInterval;

	// Token: 0x04006A09 RID: 27145
	public int GroupStatusButtonInterval;

	// Token: 0x04006A0A RID: 27146
	public int PingServerResultSendInterval;

	// Token: 0x04006A0B RID: 27147
	public int PingServersInterval;

	// Token: 0x04006A0C RID: 27148
	public int FirstCycleDelaySeconds;

	// Token: 0x04006A0D RID: 27149
	public int SecondCycleDelaySeconds;

	// Token: 0x04006A0E RID: 27150
	public int NextCycleDelaySeconds;

	// Token: 0x04006A0F RID: 27151
	public int AdditionalRandomDelaySeconds;

	// Token: 0x04006A10 RID: 27152
	public int DefaultRetriesCount;

	// Token: 0x04006A11 RID: 27153
	public int CriticalRetriesCount;

	// Token: 0x04006A12 RID: 27154
	public bool Mark502and504AsNonImportant;

	// Token: 0x04006A13 RID: 27155
	public bool DisablePrewarmsSoundsForObservers;

	// Token: 0x04006A14 RID: 27156
	public GClass1300.GClass1302 FramerateLimit;

	// Token: 0x04006A15 RID: 27157
	public GClass1300.GClass1303 NetworkStateView;

	// Token: 0x04006A16 RID: 27158
	public GClass769.MemoryManagementSettings MemoryManagementSettings;

	// Token: 0x04006A17 RID: 27159
	public bool NVidiaHighlights;

	// Token: 0x04006A18 RID: 27160
	public GClass1300.GClass1301 ReleaseProfiler;

	// Token: 0x04006A19 RID: 27161
	public bool WebDiagnosticsEnabled;

	// Token: 0x04006A1A RID: 27162
	public float WeaponOverlapDistanceCulling;

	// Token: 0x04006A1B RID: 27163
	public float AFKTimeoutSeconds;

	// Token: 0x04006A1C RID: 27164
	public string[] RequestsMadeThroughLobby;

	// Token: 0x04006A1D RID: 27165
	public float LobbyKeepAliveInterval;

	// Token: 0x04006A1E RID: 27166
	public float[] RequestConfirmationTimeouts;

	// Token: 0x04006A1F RID: 27167
	public bool ShouldEstablishLobbyConnection;

	// Token: 0x020011A3 RID: 4515
	public class GClass1301
	{
		// Token: 0x04006A20 RID: 27168
		public bool Enabled;

		// Token: 0x04006A21 RID: 27169
		public double RecordTriggerValue;

		// Token: 0x04006A22 RID: 27170
		public int MaxRecords;
	}

	// Token: 0x020011A4 RID: 4516
	public class GClass1302
	{
		// Token: 0x04006A23 RID: 27171
		public int MinFramerateLimit;

		// Token: 0x04006A24 RID: 27172
		public int MaxFramerateLobbyLimit;

		// Token: 0x04006A25 RID: 27173
		public int MaxFramerateGameLimit;
	}

	// Token: 0x020011A5 RID: 4517
	public class GClass1303
	{
		// Token: 0x04006A26 RID: 27174
		public int LossThreshold;

		// Token: 0x04006A27 RID: 27175
		public int RttThreshold;
	}
}
