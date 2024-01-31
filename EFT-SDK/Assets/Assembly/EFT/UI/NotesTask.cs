using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002B25 RID: 11045
	public sealed class NotesTask : UIElement
	{
		// Token: 0x14000302 RID: 770
		// (add) Token: 0x0600DAF2 RID: 56050 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600DAF3 RID: 56051 RVA: 0x00002050 File Offset: 0x00000250
		public event Action<RectTransform> OnSelected
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

		// Token: 0x1700268F RID: 9871
		// (get) Token: 0x0600DAF4 RID: 56052 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DAF5 RID: 56053 RVA: 0x00002050 File Offset: 0x00000250
		private bool Boolean_0
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

		// Token: 0x0600DAF6 RID: 56054 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DAF7 RID: 56055 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void Show(GClass1246 quest, ISession session, GInterface313 controller, AbstractQuestControllerClass questController, NotesTaskDescriptionShort description, bool availability)
		{
			throw null;
		}

		// Token: 0x0600DAF8 RID: 56056 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_0()
		{
			throw null;
		}

		// Token: 0x0600DAF9 RID: 56057 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_1()
		{
			throw null;
		}

		// Token: 0x0600DAFA RID: 56058 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(Color color)
		{
			throw null;
		}

		// Token: 0x0600DAFB RID: 56059 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(bool selected)
		{
			throw null;
		}

		// Token: 0x0600DAFC RID: 56060 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private Color method_4(string key)
		{
			throw null;
		}

		// Token: 0x0600DAFD RID: 56061 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_5()
		{
			throw null;
		}

		// Token: 0x0600DAFE RID: 56062 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_6()
		{
			throw null;
		}

		// Token: 0x0600DAFF RID: 56063 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DB00 RID: 56064 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_7(bool arg)
		{
			throw null;
		}

		// Token: 0x0400DE40 RID: 56896
		[CompilerGenerated]
		private Action<RectTransform> action_0;

		// Token: 0x0400DE41 RID: 56897
		private const string string_0 = "default";

		// Token: 0x0400DE42 RID: 56898
		[SerializeField]
		private QuestProgressView _progressView;

		// Token: 0x0400DE43 RID: 56899
		[SerializeField]
		private List<Image> _backgroundImages;

		// Token: 0x0400DE44 RID: 56900
		[SerializeField]
		private List<TextMeshProUGUI> _labels;

		// Token: 0x0400DE45 RID: 56901
		[SerializeField]
		private Image _statusBackground;

		// Token: 0x0400DE46 RID: 56902
		[SerializeField]
		private Image _traderAvatar;

		// Token: 0x0400DE47 RID: 56903
		[SerializeField]
		private Image _typeIcon;

		// Token: 0x0400DE48 RID: 56904
		[SerializeField]
		private TextMeshProUGUI _taskLabel;

		// Token: 0x0400DE49 RID: 56905
		[SerializeField]
		private TextMeshProUGUI _statusLabel;

		// Token: 0x0400DE4A RID: 56906
		[SerializeField]
		private TextMeshProUGUI _locationLabel;

		// Token: 0x0400DE4B RID: 56907
		[SerializeField]
		private TextMeshProUGUI _timerLabel;

		// Token: 0x0400DE4C RID: 56908
		[SerializeField]
		private ColorMap _colorMap;

		// Token: 0x0400DE4D RID: 56909
		[SerializeField]
		private float _notAvailableAlphaMultiplier;

		// Token: 0x0400DE4E RID: 56910
		[SerializeField]
		private GameObject[] _dailyQuestObjects;

		// Token: 0x0400DE4F RID: 56911
		[SerializeField]
		private Image ScavBackground;

		// Token: 0x0400DE50 RID: 56912
		[CompilerGenerated]
		private bool bool_0;

		// Token: 0x0400DE51 RID: 56913
		private readonly Dictionary<TextMeshProUGUI, Color> dictionary_0;

		// Token: 0x0400DE52 RID: 56914
		private NotesTaskDescriptionShort notesTaskDescriptionShort_0;

		// Token: 0x0400DE53 RID: 56915
		private GClass1246 gclass1246_0;

		// Token: 0x0400DE54 RID: 56916
		private ISession ginterface145_0;

		// Token: 0x0400DE55 RID: 56917
		private GInterface313 ginterface313_0;

		// Token: 0x0400DE56 RID: 56918
		private AbstractQuestControllerClass gclass3203_0;

		// Token: 0x0400DE57 RID: 56919
		private IEnumerator ienumerator_0;
	}
}
