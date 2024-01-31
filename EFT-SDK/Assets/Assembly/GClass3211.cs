using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002FC7 RID: 12231
public sealed class GClass3211
{
	// Token: 0x17002966 RID: 10598
	// (get) Token: 0x0600F18F RID: 61839 RVA: 0x00002050 File Offset: 0x00000250
	public static GClass3211 Instance
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		get
		{
			throw null;
		}
	}

	// Token: 0x0600F190 RID: 61840 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IReadOnlyCollection<RawQuestClass> GetAllProfileQuestTemplates(string profileId)
	{
		throw null;
	}

	// Token: 0x0600F191 RID: 61841 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IReadOnlyCollection<RawQuestClass> GetAllQuestTemplates()
	{
		throw null;
	}

	// Token: 0x0600F192 RID: 61842 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IReadOnlyCollection<GClass3255> GetAllAchievementTemplates()
	{
		throw null;
	}

	// Token: 0x0600F193 RID: 61843 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private IReadOnlyCollection<T> method_0<T, U>(IReadOnlyCollection<T> templatesCollection, Dictionary<string, U> profileTemplatesDict = null, string profileId = "") where T : class where U : GClass3248<T>
	{
		throw null;
	}

	// Token: 0x0600F194 RID: 61844 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGlobalQuestTemplates(IEnumerable<RawQuestClass> globalTemplates)
	{
		throw null;
	}

	// Token: 0x0600F195 RID: 61845 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddGlobalAchievementTemplates(IEnumerable<GClass3255> globalTemplates)
	{
		throw null;
	}

	// Token: 0x0600F196 RID: 61846 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void RemoveProfileQuestTemplate(string profileId, RawQuestClass template)
	{
		throw null;
	}

	// Token: 0x0600F197 RID: 61847 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void AddProfileQuestTemplates(string profileId, IEnumerable<RawQuestClass> profileTemplates)
	{
		throw null;
	}

	// Token: 0x0600F198 RID: 61848 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public bool AddProfileQuestTemplate(string profileId, RawQuestClass profileTemplate)
	{
		throw null;
	}

	// Token: 0x0600F199 RID: 61849 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	private U method_1<T, U>(string profileId, IDictionary<string, U> conditionalTemplatesCollection) where T : class where U : GClass3248<T>, new()
	{
		throw null;
	}

	// Token: 0x0600F19A RID: 61850 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public void SetChangeRequirements(Dictionary<string, GStruct404> requirements)
	{
		throw null;
	}

	// Token: 0x0600F19B RID: 61851 RVA: 0x00002050 File Offset: 0x00000250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GStruct404 GetChangeRequirements(string templateId)
	{
		throw null;
	}

	// Token: 0x0400F797 RID: 63383
	private static readonly Lazy<GClass3211> lazy_0;

	// Token: 0x0400F798 RID: 63384
	public readonly GClass3249 GlobalQuestTemplates;

	// Token: 0x0400F799 RID: 63385
	public readonly GClass3250 GlobalAchievementTemplates;

	// Token: 0x0400F79A RID: 63386
	private readonly Dictionary<string, GClass3249> dictionary_0;

	// Token: 0x0400F79B RID: 63387
	private readonly Dictionary<string, GStruct404> dictionary_1;
}
