using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace EFT.UI
{
	// Token: 0x02002C25 RID: 11301
	public abstract class BaseDropDownBox : InteractableElement, IPointerEnterHandler, IEventSystemHandler, IPointerExitHandler
	{
		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600DEBD RID: 57021 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<int> OnValueChanged
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600DEBE RID: 57022 RVA: 0x00002050 File Offset: 0x00000250
		public GInterface387<int> OnDropdownClosed
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600DEBF RID: 57023 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DEC0 RID: 57024 RVA: 0x00002050 File Offset: 0x00000250
		public int CurrentIndex
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

		// Token: 0x170026ED RID: 9965
		// (get) Token: 0x0600DEC1 RID: 57025 RVA: 0x00002050 File Offset: 0x00000250
		protected bool CurrentState
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600DEC2 RID: 57026 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform ElementsContainer
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600DEC3 RID: 57027 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600DEC4 RID: 57028 RVA: 0x00002050 File Offset: 0x00000250
		public override bool Interactable
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
			[MethodImpl(MethodImplOptions.NoInlining)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600DEC5 RID: 57029 RVA: 0x00002050 File Offset: 0x00000250
		protected RectTransform OpenPanel
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600DEC6 RID: 57030 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void Awake()
		{
			throw null;
		}

		// Token: 0x0600DEC7 RID: 57031 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Init()
		{
			throw null;
		}

		// Token: 0x0600DEC8 RID: 57032 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void Show(Func<IEnumerable<string>> values, Func<int, bool> validator = null)
		{
			throw null;
		}

		// Token: 0x0600DEC9 RID: 57033 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public virtual void Show(IEnumerable<string> values, Func<int, bool> validator = null)
		{
			throw null;
		}

		// Token: 0x0600DECA RID: 57034 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected void ToggleMenu(bool state)
		{
			throw null;
		}

		// Token: 0x0600DECB RID: 57035 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		internal void method_1()
		{
			throw null;
		}

		// Token: 0x0600DECC RID: 57036 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void UpdateValue(int value, bool sendCallback = true, int? min = null, int? max = null)
		{
			throw null;
		}

		// Token: 0x0600DECD RID: 57037 RVA: 0x00002050 File Offset: 0x00000250
		[UsedImplicitly]
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void Update()
		{
			throw null;
		}

		// Token: 0x0600DECE RID: 57038 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		protected virtual void HoverDropDownEventHandler(bool value)
		{
			throw null;
		}

		// Token: 0x0600DECF RID: 57039 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetState(bool open)
		{
			throw null;
		}

		// Token: 0x0600DED0 RID: 57040 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerEnterHandler.OnPointerEnter([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DED1 RID: 57041 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		void IPointerExitHandler.OnPointerExit([NotNull] PointerEventData eventData)
		{
			throw null;
		}

		// Token: 0x0600DED2 RID: 57042 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public void SetLabelText(string text)
		{
			throw null;
		}

		// Token: 0x0600DED3 RID: 57043 RVA: 0x00002050 File Offset: 0x00000250
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override void Close()
		{
			throw null;
		}

		// Token: 0x0600DED4 RID: 57044
		protected abstract void SetPanelState(bool open);

		// Token: 0x0600DED5 RID: 57045
		protected abstract void SetTextInternal(string text);

		// Token: 0x0600DED6 RID: 57046 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_2(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0600DED7 RID: 57047 RVA: 0x00002050 File Offset: 0x00000250
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.NoInlining)]
		private void method_3(PointerEventData arg)
		{
			throw null;
		}

		// Token: 0x0400E3A8 RID: 58280
		[SerializeField]
		private RectTransform _openPanel;

		// Token: 0x0400E3A9 RID: 58281
		[SerializeField]
		private RectTransform _elementsContainer;

		// Token: 0x0400E3AA RID: 58282
		[SerializeField]
		private Button _elementTemplate;

		// Token: 0x0400E3AB RID: 58283
		private readonly GClass3355<int> gclass3355_0;

		// Token: 0x0400E3AC RID: 58284
		private readonly GClass3355<int> gclass3355_1;

		// Token: 0x0400E3AD RID: 58285
		private Vector2 vector2_0;

		// Token: 0x0400E3AE RID: 58286
		private bool bool_0;

		// Token: 0x0400E3AF RID: 58287
		private bool bool_1;

		// Token: 0x0400E3B0 RID: 58288
		private readonly List<BaseDropDownBox.Struct932> list_0;

		// Token: 0x0400E3B1 RID: 58289
		private bool bool_2;

		// Token: 0x0400E3B2 RID: 58290
		private Func<int, bool> func_2;

		// Token: 0x0400E3B3 RID: 58291
		[CompilerGenerated]
		private int int_0;

		// Token: 0x02002C26 RID: 11302
		[StructLayout(LayoutKind.Auto)]
		public struct Struct932
		{
			// Token: 0x0400E3B4 RID: 58292
			public string Label;

			// Token: 0x0400E3B5 RID: 58293
			public bool Enabled;
		}

		// Token: 0x02002C27 RID: 11303
		[CompilerGenerated]
		private sealed class Class2689
		{
			// Token: 0x0600DED8 RID: 57048 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E3B6 RID: 58294
			public BaseDropDownBox baseDropDownBox_0;

			// Token: 0x0400E3B7 RID: 58295
			public Func<IEnumerable<string>> values;

			// Token: 0x0400E3B8 RID: 58296
			public Func<int, bool> validator;
		}

		// Token: 0x02002C28 RID: 11304
		[CompilerGenerated]
		private sealed class Class2690
		{
			// Token: 0x0600DED9 RID: 57049 RVA: 0x00002050 File Offset: 0x00000250
			[MethodImpl(MethodImplOptions.NoInlining)]
			internal void method_0()
			{
				throw null;
			}

			// Token: 0x0400E3B9 RID: 58297
			public int index;

			// Token: 0x0400E3BA RID: 58298
			public BaseDropDownBox baseDropDownBox_0;
		}
	}
}
