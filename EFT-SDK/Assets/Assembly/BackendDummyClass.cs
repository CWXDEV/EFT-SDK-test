using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using ChatShared;
using Comfort.Common;
using Diz.Binding;
using EFT;
using EFT.HandBook;
using EFT.Hideout;
using EFT.Trading;
using EFT.UI.Ragfair;
using JsonType;
using UnityEngine;

// Token: 0x02001797 RID: 6039
public sealed class BackendDummyClass : IBackendStatus, IBackendInterface<BackendDummyClass.GClass1828>
{
	// Token: 0x060080CA RID: 32970 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static BackendDummyClass smethod_0(string ipAddress = "localhost", int port = 7777, bool loadTemplatesFromBackend = false)
	{
		throw null;
	}

	// Token: 0x170013F7 RID: 5111
	// (get) Token: 0x060080CB RID: 32971 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060080CC RID: 32972 RVA: 0x00002050 File Offset: 0x00000250
	public BackendStatus Status
	{
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170013F8 RID: 5112
	// (get) Token: 0x060080CD RID: 32973 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060080CE RID: 32974 RVA: 0x00002050 File Offset: 0x00000250
	public BackendDummyClass.GClass1828 Session
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x170013F9 RID: 5113
	// (get) Token: 0x060080CF RID: 32975 RVA: 0x00002050 File Offset: 0x00000250
	// (set) Token: 0x060080D0 RID: 32976 RVA: 0x00002050 File Offset: 0x00000250
	public GInterface178 TradingSession
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
		[MethodImpl(MethodImplOptions.NoInlining)]
		private set
		{
			throw null;
		}
	}

	// Token: 0x060080D1 RID: 32977 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void ManualUpdate()
	{
		throw null;
	}

	// Token: 0x060080D2 RID: 32978 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void FlushOperationQueue(Callback callback)
	{
		throw null;
	}

	// Token: 0x060080D3 RID: 32979 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<IResult> FlushOperationQueue()
	{
		throw null;
	}

	// Token: 0x060080D4 RID: 32980 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RegisterDevice(string email, string activateCode, Callback onFinished)
	{
		throw null;
	}

	// Token: 0x060080D5 RID: 32981 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<BackendDummyClass.GClass1828> CreateClientSession()
	{
		throw null;
	}

	// Token: 0x060080D6 RID: 32982 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task RegenerateToken()
	{
		throw null;
	}

	// Token: 0x060080D7 RID: 32983 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task ValidateVersion()
	{
		throw null;
	}

	// Token: 0x060080D8 RID: 32984 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Result<GClass798>> Login(string login, string password)
	{
		throw null;
	}

	// Token: 0x060080D9 RID: 32985 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void LoadFromFile<T>(string fileName, Callback<T> onFinished)
	{
		throw null;
	}

	// Token: 0x060080DA RID: 32986 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void smethod_1<T>(string url, Callback<T> onFinished)
	{
		throw null;
	}

	// Token: 0x060080DB RID: 32987 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<GClass1397> GetMainMenuLocalization(string locale)
	{
		throw null;
	}

	// Token: 0x060080DC RID: 32988 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task<Dictionary<string, string>> GetAvailableLanguages()
	{
		throw null;
	}

	// Token: 0x060080DD RID: 32989 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Logout()
	{
		throw null;
	}

	// Token: 0x060080DE RID: 32990 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void EnableDiagnostics(bool webDiagnosticsEnabled)
	{
		throw null;
	}

	// Token: 0x060080DF RID: 32991 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Task Destroy()
	{
		throw null;
	}

	// Token: 0x04008994 RID: 35220
	private readonly string string_0;

	// Token: 0x04008995 RID: 35221
	private readonly int int_0;

	// Token: 0x04008996 RID: 35222
	private readonly float float_0;

	// Token: 0x04008997 RID: 35223
	private readonly bool bool_0;

	// Token: 0x04008998 RID: 35224
	private BackendDummyClass.GClass1828 gclass1828_0;

	// Token: 0x04008999 RID: 35225
	[CompilerGenerated]
	private BackendStatus backendStatus_0;

	// Token: 0x02001798 RID: 6040
	public sealed class GClass1828 : GInterface16, GInterface144, ISession, GInterface146, GInterface178, GInterface181
	{
		// Token: 0x14000181 RID: 385
		// (add) Token: 0x060080E0 RID: 32992 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060080E1 RID: 32993 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<int, string> InventoryErrorHappened
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000182 RID: 386
		// (add) Token: 0x060080E2 RID: 32994 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060080E3 RID: 32995 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<EBackendErrorCode, string> OnSessionError
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000183 RID: 387
		// (add) Token: 0x060080E4 RID: 32996 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060080E5 RID: 32997 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<IInventoryWarning> InventoryWarningHappened
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetPhpSessionId()
		{
			throw null;
		}

		// Token: 0x170013FA RID: 5114
		// (get) Token: 0x060080E7 RID: 32999 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface14 Cache
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013FB RID: 5115
		// (get) Token: 0x060080E8 RID: 33000 RVA: 0x00002050 File Offset: 0x00000250
		public long TotalInGameTime
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013FC RID: 5116
		// (get) Token: 0x060080E9 RID: 33001 RVA: 0x00002050 File Offset: 0x00000250
		public bool ReportAvailable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170013FD RID: 5117
		// (get) Token: 0x060080EA RID: 33002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080EB RID: 33003 RVA: 0x00002050 File Offset: 0x00000250
		public LocationSettingsClass LocationSettings
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170013FE RID: 5118
		// (get) Token: 0x060080EC RID: 33004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080ED RID: 33005 RVA: 0x00002050 File Offset: 0x00000250
		public Profile[] AllProfiles
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x170013FF RID: 5119
		// (get) Token: 0x060080EE RID: 33006 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080EF RID: 33007 RVA: 0x00002050 File Offset: 0x00000250
		public Profile Profile
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001400 RID: 5120
		// (get) Token: 0x060080F0 RID: 33008 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080F1 RID: 33009 RVA: 0x00002050 File Offset: 0x00000250
		public SessionCountersClass OverallAccountStats
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x17001401 RID: 5121
		// (get) Token: 0x060080F2 RID: 33010 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080F3 RID: 33011 RVA: 0x00002050 File Offset: 0x00000250
		public float ProfilesUpdateTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001402 RID: 5122
		// (get) Token: 0x060080F4 RID: 33012 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080F5 RID: 33013 RVA: 0x00002050 File Offset: 0x00000250
		public bool LimitedServersAvailability
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001403 RID: 5123
		// (get) Token: 0x060080F6 RID: 33014 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080F7 RID: 33015 RVA: 0x00002050 File Offset: 0x00000250
		public PlayerVisualRepresentation LastPlayerState
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17001404 RID: 5124
		// (get) Token: 0x060080F8 RID: 33016 RVA: 0x00002050 File Offset: 0x00000250
		public Profile ProfileOfPet
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001405 RID: 5125
		// (get) Token: 0x060080F9 RID: 33017 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060080FA RID: 33018 RVA: 0x00002050 File Offset: 0x00000250
		public ProfileStatusClass[] AllProfileStatus
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17001406 RID: 5126
		// (get) Token: 0x060080FB RID: 33019 RVA: 0x00002050 File Offset: 0x00000250
		public ProfileStatusClass ActiveProfileStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001407 RID: 5127
		// (get) Token: 0x060080FC RID: 33020 RVA: 0x00002050 File Offset: 0x00000250
		public ProfileStatusClass ActivePetStatus
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public ProfileStatusClass GetProfileStatus(bool isPet)
		{
			throw null;
		}

		// Token: 0x17001408 RID: 5128
		// (get) Token: 0x060080FE RID: 33022 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsWinter
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001409 RID: 5129
		// (get) Token: 0x060080FF RID: 33023 RVA: 0x00002050 File Offset: 0x00000250
		public WeatherClass Weather
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x06008100 RID: 33024 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008101 RID: 33025 RVA: 0x00002050 File Offset: 0x00000250
		public string LocationTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x06008102 RID: 33026 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008103 RID: 33027 RVA: 0x00002050 File Offset: 0x00000250
		public float Acceleration
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x06008104 RID: 33028 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008105 RID: 33029 RVA: 0x00002050 File Offset: 0x00000250
		public ChatServerClass[] ChatServers
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008106 RID: 33030 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Profile GetProfileBySide(ESideType side)
		{
			throw null;
		}

		// Token: 0x06008107 RID: 33031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public string GetSessionId(bool isPet)
		{
			throw null;
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x06008108 RID: 33032 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008109 RID: 33033 RVA: 0x00002050 File Offset: 0x00000250
		public GameServerClass[] GameServers
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600810A RID: 33034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ClearProfileUpdaters()
		{
			throw null;
		}

		// Token: 0x0600810B RID: 33035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterProfileUpdater(string profileId, GInterface142 profileUpdater)
		{
			throw null;
		}

		// Token: 0x0600810C RID: 33036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RegisterCaptchaHandler(GInterface143 captchaHandler)
		{
			throw null;
		}

		// Token: 0x0600810D RID: 33037 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<ECaptchaResult>> RequestCaptcha()
		{
			throw null;
		}

		// Token: 0x0600810E RID: 33038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<string[]> GetAvailableAccountCustomization()
		{
			throw null;
		}

		// Token: 0x0600810F RID: 33039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeNickname(string profileId, string nickname, Callback<GClass688> callback)
		{
			throw null;
		}

		// Token: 0x06008110 RID: 33040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ValidateNickname(string profileNickname, Callback<object> callback)
		{
			throw null;
		}

		// Token: 0x06008111 RID: 33041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetReservedNickname(Callback<string> callback)
		{
			throw null;
		}

		// Token: 0x06008112 RID: 33042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateProfile(EPlayerSide profileSide, string profileNickname, string headId, string voiceId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008113 RID: 33043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartKeepAliveCoroutine(int keepAliveInterval)
		{
			throw null;
		}

		// Token: 0x06008114 RID: 33044 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1203> GetTemplates(GClass1203 defaultValueInCaseOfCache)
		{
			throw null;
		}

		// Token: 0x06008115 RID: 33045 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Dictionary<string, GClass2932>> GetCustomizations()
		{
			throw null;
		}

		// Token: 0x06008116 RID: 33046 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Dictionary<string, string>> GetLocalization(string locale)
		{
			throw null;
		}

		// Token: 0x06008117 RID: 33047 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass2882<HandbookData>> RequestHandbookInfo()
		{
			throw null;
		}

		// Token: 0x06008118 RID: 33048 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<string[]> GetAvailableSuites()
		{
			throw null;
		}

		// Token: 0x06008119 RID: 33049 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> RequestBuilds()
		{
			throw null;
		}

		// Token: 0x0600811A RID: 33050 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> SaveMagBuild(GClass2089 preset)
		{
			throw null;
		}

		// Token: 0x0600811B RID: 33051 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshProfileStatuses(bool isPet, Callback<ProfileStatusClass[]> callback = null)
		{
			throw null;
		}

		// Token: 0x0600811C RID: 33052 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<LocationSettingsClass> GetLevelSettings()
		{
			throw null;
		}

		// Token: 0x0600811D RID: 33053 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1225> SetMainProfile(Profile profile)
		{
			throw null;
		}

		// Token: 0x0600811E RID: 33054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task GetProfiles()
		{
			throw null;
		}

		// Token: 0x0600811F RID: 33055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeProfileStatus(ProfileStatusClass status)
		{
			throw null;
		}

		// Token: 0x06008120 RID: 33056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetRaidReadyStatus(string locationId, bool savage, string dt, string keyId, ERaidMode raidMode, EPlayersSpawnPlace spawnPlace, Callback<GClass1211> callback)
		{
			throw null;
		}

		// Token: 0x06008121 RID: 33057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendClientProfileSettings(bool groupInvitesRestrict, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008122 RID: 33058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendGroupInvite(string accountId, bool inLobby, Callback<string> callback)
		{
			throw null;
		}

		// Token: 0x06008123 RID: 33059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CancelInvite(string requestId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008124 RID: 33060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CancelAllInvites(Callback callback)
		{
			throw null;
		}

		// Token: 0x06008125 RID: 33061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AcceptGroupInvite(string requestId, Callback<GClass1206[]> callback)
		{
			throw null;
		}

		// Token: 0x06008126 RID: 33062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetGroupStatus(Callback<GClass1212> callback)
		{
			throw null;
		}

		// Token: 0x06008127 RID: 33063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeclineGroupInvite(string requestId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008128 RID: 33064 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetReadyRaidStatus(Callback callback)
		{
			throw null;
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetNotReadyReadyStatus(Callback callback)
		{
			throw null;
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DisbandRaidGroup(Callback callback)
		{
			throw null;
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> LeaveMatchmakerGroup()
		{
			throw null;
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemovePlayerFromGroup(string profileAid, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> ExitFromMatchmakerGroupMenu()
		{
			throw null;
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransferGroupLeadership(string profileAid, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1193> StartGameGroupLeader(string groupId, bool isPet)
		{
			throw null;
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1193> StartGameGroupPlayer(string groupId, bool isPet)
		{
			throw null;
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> CancelGameSearching(bool isPet)
		{
			throw null;
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> StartLookingForGroup()
		{
			throw null;
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> StopLookingForGroup()
		{
			throw null;
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool PlayerAlreadyReported(string playerId)
		{
			throw null;
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public bool OfferAlreadyReported(long offerId)
		{
			throw null;
		}

		// Token: 0x06008136 RID: 33078 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatGetDialogList(int limit, int offset, Callback<GClass930[]> callback)
		{
			throw null;
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatCreateGroupDialog(string chatName, string[] groupMembers, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatSendMessage(string id, int type, string text, string replyTo, Callback<string> callback)
		{
			throw null;
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatDeleteMessage(string dialogId, string messageId, Callback<string> callback)
		{
			throw null;
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> ChatDeleteAllMessages(string dialogId)
		{
			throw null;
		}

		// Token: 0x0600813B RID: 33083 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> DeleteDialog(string dialogId)
		{
			throw null;
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatGetDialogMessages(string id, int type, int limit, double time, Callback<GClass932> callback)
		{
			throw null;
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PinDialog(string dialogId, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AllAttachmentsFromDialog(string dialogId, Callback<GClass932> callback)
		{
			throw null;
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> RedeemProfileRewards(GStruct72[] rewards)
		{
			throw null;
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnpinDialog(string dialogId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetDialogInformation(string dialogId, Callback<GClass930> callback)
		{
			throw null;
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void MutePlayer(string uid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UnmutePlayer(string uid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InviteToDialogue(string dialogId, string[] uid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromDialogue(string dialogId, string uid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LeaveChatDialogue(string dialogId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChatReadDialogues(string[] dialogs, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008148 RID: 33096 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindAccountByNickname(string nickname, Callback<UpdatableChatMember[]> callback)
		{
			throw null;
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetFriendsList(Callback<GClass926> callback)
		{
			throw null;
		}

		// Token: 0x0600814A RID: 33098 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromFriendsList(string id, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetInputFriendsRequests(Callback<GClass927[]> callback)
		{
			throw null;
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOutputFriendsRequests(Callback<GClass927[]> callback)
		{
			throw null;
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendFriendRequest(string id, Callback<GClass3172> callback)
		{
			throw null;
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> CancelFriendRequest(string profileId)
		{
			throw null;
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AcceptFriendRequest(string profileId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task AcceptAllFriendRequests()
		{
			throw null;
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void DeclineFriendRequest(string profileId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TransferChatLeadership(string dialogId, string uid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadTextureRagfair(string url, bool cacheOnDisk, Callback<Texture2D> callback = null)
		{
			throw null;
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void LoadTextureMain(string url, Callback<Texture2D> callback = null)
		{
			throw null;
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x06008155 RID: 33109 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<TraderClass> Traders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x06008156 RID: 33110 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<TraderClass> DisplayableTraders
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x06008157 RID: 33111 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<TraderClass> Insurers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001411 RID: 5137
		// (get) Token: 0x06008158 RID: 33112 RVA: 0x00002050 File Offset: 0x00000250
		public IEnumerable<TraderClass> Repairers
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001412 RID: 5138
		// (get) Token: 0x06008159 RID: 33113 RVA: 0x00002050 File Offset: 0x00000250
		public TraderClass Medic
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001413 RID: 5139
		// (get) Token: 0x0600815A RID: 33114 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2087 RepairController
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001414 RID: 5140
		// (get) Token: 0x0600815B RID: 33115 RVA: 0x00002050 File Offset: 0x00000250
		public InsuranceCompanyClass InsuranceCompany
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001415 RID: 5141
		// (get) Token: 0x0600815C RID: 33116 RVA: 0x00002050 File Offset: 0x00000250
		public RagFairClass RagFair
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001416 RID: 5142
		// (get) Token: 0x0600815D RID: 33117 RVA: 0x00002050 File Offset: 0x00000250
		public GClass3184 WeaponBuildsStorage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001417 RID: 5143
		// (get) Token: 0x0600815E RID: 33118 RVA: 0x00002050 File Offset: 0x00000250
		public GClass3182 EquipmentBuildsStorage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001418 RID: 5144
		// (get) Token: 0x0600815F RID: 33119 RVA: 0x00002050 File Offset: 0x00000250
		public GClass2088 MagBuildsStorage
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17001419 RID: 5145
		// (get) Token: 0x06008160 RID: 33120 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008161 RID: 33121 RVA: 0x00002050 File Offset: 0x00000250
		public GClass1839 SocialNetwork
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008162 RID: 33122 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		TraderClass GInterface178.GetTrader(string traderId)
		{
			throw null;
		}

		// Token: 0x06008163 RID: 33123 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairAddOffer(bool sellInOnePiece, string[] items, GClass1841[] requirements, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008164 RID: 33124 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairRemoveOffer(string offerId, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008165 RID: 33125 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairRenewOffer(string offerId, bool priority, int renewalTime, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008166 RID: 33126 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairPurchaseOffers(CustomizationClass commodities, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008167 RID: 33127 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<CaptchaData>> GetCaptcha()
		{
			throw null;
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<GClass1842>> ValidateCaptcha(IEnumerable<string> items, string captchaType)
		{
			throw null;
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairReportOffer(long offerId, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RagfairGetPrices(Callback<Dictionary<string, float>> callback)
		{
			throw null;
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<OffersList>> GetOffers(int page, int limit, int sortType, bool direction, int currency, int priceFrom, int priceTo, int quantityFrom, int quantityTo, int conditionFrom, int conditionTo, bool oneHourExpiration, bool removeBartering, int offerOwnerType, bool onlyFunctional, string handbookId, string linkedSearchId, string neededSearchId, Dictionary<string, int> buildItems, int buildCount, bool updateOfferCount)
		{
			throw null;
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetMarketPrices(string templateId, Callback<ItemMarketPrices> callback)
		{
			throw null;
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AddToWishList(string templateId, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RemoveFromWishList(string templateId, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void FindById(long id, Callback<Offer> callback)
		{
			throw null;
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReadEncyclopedia(string[] ids, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> RepairItemsByTrader(string traderId, RepairItem repairItem)
		{
			throw null;
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> RepairItemsByRepairKit(RepairItem[] repairKitsInfo, string targetItemId)
		{
			throw null;
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> Unpack(string targetItemId, string profileId)
		{
			throw null;
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1225> SelectProfile(string profileId)
		{
			throw null;
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<bool> IsMatchingAvailable()
		{
			throw null;
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1193> StartMatching(string locationId, bool isPet, EDateTime dateTime, string keyId)
		{
			throw null;
		}

		// Token: 0x06008177 RID: 33143 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private IEnumerator method_0(string locationId, bool isPet, Callback<GClass1193> callback)
		{
			throw null;
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void AbortMatching(bool isPet, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendOperationRightNow(object operation, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendOperationQueued(object operation, Action<Callback> execute, Callback callback)
		{
			throw null;
		}

		// Token: 0x1700141A RID: 5146
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600817C RID: 33148 RVA: 0x00002050 File Offset: 0x00000250
		public bool IsFlushing
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700141B RID: 5147
		// (get) Token: 0x0600817D RID: 33149 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600817E RID: 33150 RVA: 0x00002050 File Offset: 0x00000250
		public EOperationQueueStatus QueueStatus
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700141C RID: 5148
		// (get) Token: 0x0600817F RID: 33151 RVA: 0x00002050 File Offset: 0x00000250
		public BindableEvent QueueStatusChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700141D RID: 5149
		// (get) Token: 0x06008180 RID: 33152 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008181 RID: 33153 RVA: 0x00002050 File Offset: 0x00000250
		public Action<string> ExamineRequestFailed
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700141E RID: 5150
		// (get) Token: 0x06008182 RID: 33154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008183 RID: 33155 RVA: 0x00002050 File Offset: 0x00000250
		public DateTime GetCurrentLocationTime
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008184 RID: 33156 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<LocationWeatherTime> GetWeatherAndTime()
		{
			throw null;
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CreateNotifierChannel(Callback<GClass1227> callback)
		{
			throw null;
		}

		// Token: 0x1700141F RID: 5151
		// (get) Token: 0x06008186 RID: 33158 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06008187 RID: 33159 RVA: 0x00002050 File Offset: 0x00000250
		public bool Destroyed
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x06008188 RID: 33160 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Destroy()
		{
			throw null;
		}

		// Token: 0x06008189 RID: 33161 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TrySendCommands()
		{
			throw null;
		}

		// Token: 0x0600818A RID: 33162 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> FlushOperationQueue()
		{
			throw null;
		}

		// Token: 0x0600818B RID: 33163 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<BackendConfigClass> GetGlobalConfig()
		{
			throw null;
		}

		// Token: 0x0600818C RID: 33164 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1229> GetClientSettingsConfig()
		{
			throw null;
		}

		// Token: 0x17001420 RID: 5152
		// (get) Token: 0x0600818D RID: 33165 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600818E RID: 33166 RVA: 0x00002050 File Offset: 0x00000250
		public BackendConfigClass BackEndConfig
		{
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[MethodImpl(MethodImplOptions.NoInlining)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x0600818F RID: 33167 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<List<RawQuestClass>> RequestQuestsTemplates(bool withCompleted)
		{
			throw null;
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<DailyQuestClass[]> GetDailyQuests()
		{
			throw null;
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> QuestChange(string qid)
		{
			throw null;
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> QuestAccept(string qid, bool isRepeatable)
		{
			throw null;
		}

		// Token: 0x06008193 RID: 33171 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> QuestComplete(string questId, bool removeExcessItems, bool isRepeatable)
		{
			throw null;
		}

		// Token: 0x06008194 RID: 33172 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> AchievementComplete(string qid, bool removeExcessItems)
		{
			throw null;
		}

		// Token: 0x06008195 RID: 33173 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void QuestFail(string qid, Callback callback)
		{
			throw null;
		}

		// Token: 0x06008196 RID: 33174 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetBotSettings(BackendConfigClass backEndConfig)
		{
			throw null;
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> SaveWeaponBuild(MongoID id, string name, string root, GClass1186[] items)
		{
			throw null;
		}

		// Token: 0x06008198 RID: 33176 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> SaveEquipmentBuild(MongoID id, string name, string root, GClass1186[] items)
		{
			throw null;
		}

		// Token: 0x06008199 RID: 33177 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> RemoveBuild(MongoID id)
		{
			throw null;
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> FinishScavSession()
		{
			throw null;
		}

		// Token: 0x0600819B RID: 33179 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Profile[]> LoadBots(List<WaveInfo> limit)
		{
			throw null;
		}

		// Token: 0x0600819C RID: 33180 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetInsurancePrice(string[] traderId, string[] itemIds, Callback<Dictionary<string, Dictionary<string, int>>> callback)
		{
			throw null;
		}

		// Token: 0x0600819D RID: 33181 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void InsureItems(string[] items, string traderId, Callback callback)
		{
			throw null;
		}

		// Token: 0x0600819E RID: 33182 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetChatServers(string versionId, Callback<ChatServerClass[]> callback)
		{
			throw null;
		}

		// Token: 0x0600819F RID: 33183 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOtherPlayerProfile(string accountId, Callback<GClass1208> callback)
		{
			throw null;
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RefreshPings(int sendPingResultInterval, int pingServersInterval, Callback<GameServerClass[]> callback)
		{
			throw null;
		}

		// Token: 0x060081A1 RID: 33185 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> QuestHandover(string qid, string conditionId, GClass1223[] items)
		{
			throw null;
		}

		// Token: 0x060081A2 RID: 33186 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ChangeVoice(string voice, Callback callback = null)
		{
			throw null;
		}

		// Token: 0x060081A3 RID: 33187 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void CheckLoginQueue(Callback<GClass1191> callback)
		{
			throw null;
		}

		// Token: 0x060081A4 RID: 33188 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<MetricsConfigClass> GetMetricsConfig()
		{
			throw null;
		}

		// Token: 0x060081A5 RID: 33189 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task SendMetrics(MetricsClass metrics)
		{
			throw null;
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ApplyCustomizationWear(string[] suites, Callback onFinished)
		{
			throw null;
		}

		// Token: 0x060081A7 RID: 33191 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public AreaInfo[] GetHideoutAreasInfo()
		{
			throw null;
		}

		// Token: 0x060081A8 RID: 33192 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass748> GetAreaTemplatesUnparsed()
		{
			throw null;
		}

		// Token: 0x060081A9 RID: 33193 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1905> GetHideoutSettings()
		{
			throw null;
		}

		// Token: 0x060081AA RID: 33194 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1920[]> GetProductionRecipes()
		{
			throw null;
		}

		// Token: 0x060081AB RID: 33195 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<QteData[]> GetAreasQte()
		{
			throw null;
		}

		// Token: 0x060081AC RID: 33196 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1921[]> GetScavRecipes()
		{
			throw null;
		}

		// Token: 0x060081AD RID: 33197 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public int GetHideoutShootingRangeScore()
		{
			throw null;
		}

		// Token: 0x060081AE RID: 33198 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetHideoutShootingRangeScore(int value)
		{
			throw null;
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> HideoutProductionCancel(string recipeId)
		{
			throw null;
		}

		// Token: 0x060081B0 RID: 33200 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> HideoutProductionReset(string recipeId)
		{
			throw null;
		}

		// Token: 0x060081B1 RID: 33201 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartSingleProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools)
		{
			throw null;
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> StartScavCaseProduction(string schemeId, IEnumerable<GClass1223> items, IEnumerable<GClass1223> tools)
		{
			throw null;
		}

		// Token: 0x060081B3 RID: 33203 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartContinuousProduction(string schemeId)
		{
			throw null;
		}

		// Token: 0x060081B4 RID: 33204 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> UpgradeZone(int areaType, IEnumerable<GStruct241> items)
		{
			throw null;
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> CompleteUpgradeZone(int areaType)
		{
			throw null;
		}

		// Token: 0x060081B6 RID: 33206 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Dictionary<string, GClass1910> GetHideoutImprovements()
		{
			throw null;
		}

		// Token: 0x060081B7 RID: 33207 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StartImprovement(string id, EAreaType areaType, IEnumerable<GClass1223> items)
		{
			throw null;
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void PutItemsInAreaSlots(EAreaType areaType, Dictionary<int, GStruct241> items, Action onComplete)
		{
			throw null;
		}

		// Token: 0x060081B9 RID: 33209 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ToggleArea(EAreaType areaType, bool enabled)
		{
			throw null;
		}

		// Token: 0x060081BA RID: 33210 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> TakeHideoutProduction(string recipeId)
		{
			throw null;
		}

		// Token: 0x060081BB RID: 33211 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void TakeItemsFromAreaSlots(EAreaType areaType, int[] slots, Callback callback)
		{
			throw null;
		}

		// Token: 0x060081BC RID: 33212 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> TakeItemsFromAreaSlotsAsync(EAreaType areaType, int[] slots)
		{
			throw null;
		}

		// Token: 0x060081BD RID: 33213 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void RestoreHealth(TreatmentDataClass treatmentData, List<GClass1223> cost, string traderId)
		{
			throw null;
		}

		// Token: 0x060081BE RID: 33214 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> Logout()
		{
			throw null;
		}

		// Token: 0x060081BF RID: 33215 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		Task GInterface144.Destroy()
		{
			throw null;
		}

		// Token: 0x060081C0 RID: 33216 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1826> CheckVersion()
		{
			throw null;
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SendReport(EReportType reportType, Callback callback)
		{
			throw null;
		}

		// Token: 0x060081C2 RID: 33218 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ReportNickname(string profileId, Callback callback)
		{
			throw null;
		}

		// Token: 0x060081C3 RID: 33219 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<TraderAssortment>> GetTraderAssortment(string traderId)
		{
			throw null;
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<Dictionary<string, double>>> GetTraderMarketPrices(string traderId)
		{
			throw null;
		}

		// Token: 0x060081C5 RID: 33221 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Result<SupplyData>> GetSupplyData(string traderId)
		{
			throw null;
		}

		// Token: 0x060081C6 RID: 33222 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> SellAllFromSavage(string playerId, string petId)
		{
			throw null;
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void BuyCustomizationWear(string offer, IEnumerable<GClass1223> items, Callback onFinished)
		{
			throw null;
		}

		// Token: 0x060081C8 RID: 33224 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> ConfirmPurchase(string traderId, string itemId, int count, int schemeId, TradingItemReference[] items)
		{
			throw null;
		}

		// Token: 0x060081C9 RID: 33225 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConfirmSell(string traderId, TradingItemReference[] items, int price, Callback onFinished)
		{
			throw null;
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void GetOffers(string traderId, Callback<GClass2938[]> onFinished)
		{
			throw null;
		}

		// Token: 0x060081CB RID: 33227 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Texture2D> LoadAvatar(string url)
		{
			throw null;
		}

		// Token: 0x060081CC RID: 33228 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<LocationSettingsClass.Location> LoadLocationLoot(string locationId, int variantId)
		{
			throw null;
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task OfflineRaidEnded(ExitStatus exitStatus, string exitName, double raidSeconds)
		{
			throw null;
		}

		// Token: 0x060081CE RID: 33230 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IResult> SendRaidSettings(RaidSettings raidSettings)
		{
			throw null;
		}

		// Token: 0x060081CF RID: 33231 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<RaidSettings> ReceiveCoopRaidSettings()
		{
			throw null;
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void WorkoutEnded(IEnumerable<bool> qtesResult, string qteId, Callback callback)
		{
			throw null;
		}

		// Token: 0x060081D1 RID: 33233 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<IEnumerable<GClass3255>> RequestAchievementsTemplates(bool withCompleted)
		{
			throw null;
		}

		// Token: 0x060081D2 RID: 33234 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<Dictionary<string, float>> RequestAchievementsGlobalProgress()
		{
			throw null;
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetFavoriteItems(IEnumerable<string> items, Callback callback = null)
		{
			throw null;
		}

		// Token: 0x060081D4 RID: 33236 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void StopKeepAlive()
		{
			throw null;
		}

		// Token: 0x060081D5 RID: 33237 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void ConfigureLobbyRelatedParameters(GClass1300 config)
		{
			throw null;
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task<GClass1226> IssueWSToken()
		{
			throw null;
		}

		// Token: 0x060081D7 RID: 33239 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public Task EstablishWSConnection()
		{
			throw null;
		}

		// Token: 0x060081D8 RID: 33240 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_1(Profile p)
		{
			throw null;
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private bool method_2(ProfileStatusClass t)
		{
			throw null;
		}

		// Token: 0x0400899A RID: 35226
		[CompilerGenerated]
		private Action<int, string> action_0;

		// Token: 0x0400899B RID: 35227
		[CompilerGenerated]
		private Action<EBackendErrorCode, string> action_1;

		// Token: 0x0400899C RID: 35228
		[CompilerGenerated]
		private Action<IInventoryWarning> action_2;

		// Token: 0x0400899D RID: 35229
		private int int_0;

		// Token: 0x0400899E RID: 35230
		private BackendDummyClass gclass1827_0;

		// Token: 0x0400899F RID: 35231
		private bool bool_0;

		// Token: 0x040089A0 RID: 35232
		[CompilerGenerated]
		private LocationSettingsClass gclass1213_0;

		// Token: 0x040089A1 RID: 35233
		[CompilerGenerated]
		private Profile[] profile_0;

		// Token: 0x040089A2 RID: 35234
		[CompilerGenerated]
		private Profile profile_1;

		// Token: 0x040089A3 RID: 35235
		[CompilerGenerated]
		private SessionCountersClass gclass2198_0;

		// Token: 0x040089A4 RID: 35236
		[CompilerGenerated]
		private float float_0;

		// Token: 0x040089A5 RID: 35237
		[CompilerGenerated]
		private bool bool_1;

		// Token: 0x040089A6 RID: 35238
		[CompilerGenerated]
		private PlayerVisualRepresentation playerVisualRepresentation_0;

		// Token: 0x040089A7 RID: 35239
		[CompilerGenerated]
		private ProfileStatusClass[] gclass1744_0;

		// Token: 0x040089A8 RID: 35240
		[CompilerGenerated]
		private string string_0;

		// Token: 0x040089A9 RID: 35241
		[CompilerGenerated]
		private float float_1;

		// Token: 0x040089AA RID: 35242
		[CompilerGenerated]
		private ChatServerClass[] gclass921_0;

		// Token: 0x040089AB RID: 35243
		[CompilerGenerated]
		private GameServerClass[] gclass1176_0;

		// Token: 0x040089AC RID: 35244
		[CompilerGenerated]
		private readonly InsuranceCompanyClass gclass3179_0;

		// Token: 0x040089AD RID: 35245
		[CompilerGenerated]
		private readonly RagFairClass gclass3190_0;

		// Token: 0x040089AE RID: 35246
		[CompilerGenerated]
		private GClass1839 gclass1839_0;

		// Token: 0x040089AF RID: 35247
		private List<TraderClass> list_0;

		// Token: 0x040089B0 RID: 35248
		private GClass2087 gclass2087_0;

		// Token: 0x040089B1 RID: 35249
		[CompilerGenerated]
		private bool bool_2;

		// Token: 0x040089B2 RID: 35250
		[CompilerGenerated]
		private EOperationQueueStatus eoperationQueueStatus_0;

		// Token: 0x040089B3 RID: 35251
		private readonly BindableEvent bindableEvent_0;

		// Token: 0x040089B4 RID: 35252
		private ISession ginterface145_0;

		// Token: 0x040089B5 RID: 35253
		[CompilerGenerated]
		private Action<string> action_3;

		// Token: 0x040089B6 RID: 35254
		[CompilerGenerated]
		private DateTime dateTime_0;

		// Token: 0x040089B7 RID: 35255
		[CompilerGenerated]
		private bool bool_3;

		// Token: 0x040089B8 RID: 35256
		[CompilerGenerated]
		private BackendConfigClass gclass1228_0;

		// Token: 0x02001799 RID: 6041
		[CompilerGenerated]
		private sealed class Class1264
		{
			// Token: 0x060081DA RID: 33242 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProfileStatusClass status)
			{
				throw null;
			}

			// Token: 0x040089B9 RID: 35257
			public Profile profile;
		}

		// Token: 0x0200179A RID: 6042
		[CompilerGenerated]
		private sealed class Class1265
		{
			// Token: 0x060081DB RID: 33243 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(ProfileStatusClass status)
			{
				throw null;
			}

			// Token: 0x040089BA RID: 35258
			public Profile profile;
		}

		// Token: 0x0200179B RID: 6043
		[CompilerGenerated]
		private sealed class Class1266
		{
			// Token: 0x060081DC RID: 33244 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<ProfileStatusClass[]> result)
			{
				throw null;
			}

			// Token: 0x040089BB RID: 35259
			public BackendDummyClass.GClass1828 gclass1828_0;

			// Token: 0x040089BC RID: 35260
			public Callback<ProfileStatusClass[]> callback;
		}

		// Token: 0x0200179C RID: 6044
		[CompilerGenerated]
		private sealed class Class1267
		{
			// Token: 0x060081DD RID: 33245 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<LocationSettingsClass> result)
			{
				throw null;
			}

			// Token: 0x040089BD RID: 35261
			public BackendDummyClass.GClass1828 gclass1828_0;

			// Token: 0x040089BE RID: 35262
			public TaskCompletionSource<LocationSettingsClass> completionSource;
		}

		// Token: 0x0200179D RID: 6045
		[CompilerGenerated]
		private sealed class Class1268
		{
			// Token: 0x060081DE RID: 33246 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<Profile[]> result)
			{
				throw null;
			}

			// Token: 0x040089BF RID: 35263
			public TaskCompletionSource<Profile[]> completionSource;

			// Token: 0x040089C0 RID: 35264
			public BackendDummyClass.GClass1828 gclass1828_0;
		}

		// Token: 0x0200179E RID: 6046
		[CompilerGenerated]
		[Serializable]
		private sealed class Class1269
		{
			// Token: 0x060081DF RID: 33247 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x060081E0 RID: 33248 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_1(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x060081E1 RID: 33249 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_2(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x060081E2 RID: 33250 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_3(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x040089C1 RID: 35265
			public static readonly BackendDummyClass.GClass1828.Class1269 class1269_0;

			// Token: 0x040089C2 RID: 35266
			public static Func<TraderClass, bool> func_0;

			// Token: 0x040089C3 RID: 35267
			public static Func<TraderClass, bool> func_1;

			// Token: 0x040089C4 RID: 35268
			public static Func<TraderClass, bool> func_2;

			// Token: 0x040089C5 RID: 35269
			public static Func<TraderClass, bool> func_3;
		}

		// Token: 0x0200179F RID: 6047
		[CompilerGenerated]
		private sealed class Class1270
		{
			// Token: 0x060081E3 RID: 33251 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(TraderClass trader)
			{
				throw null;
			}

			// Token: 0x040089C6 RID: 35270
			public string traderId;
		}

		// Token: 0x020017A0 RID: 6048
		[CompilerGenerated]
		private sealed class Class1271
		{
			// Token: 0x060081E4 RID: 33252 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal bool method_0(Profile profile)
			{
				throw null;
			}

			// Token: 0x040089C7 RID: 35271
			public string profileId;
		}

		// Token: 0x020017A3 RID: 6051
		[CompilerGenerated]
		private sealed class Class1273
		{
			// Token: 0x060081EB RID: 33259 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0(Result<TraderAssortment> assort)
			{
				throw null;
			}

			// Token: 0x040089D5 RID: 35285
			public Result<TraderAssortment> assortment;
		}
	}
}
