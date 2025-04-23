using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;
using Mono.Cecil;
using nsMorello;

namespace JustDecompile.FindUsages.ViewModels.Entities
{
	// Token: 0x02000429 RID: 1065
	public abstract class SourceEntity : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06002325 RID: 8997 RVA: 0x000651D0 File Offset: 0x000633D0
		// (set) Token: 0x06002326 RID: 8998 RVA: 0x000651D8 File Offset: 0x000633D8
		public global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity ContainerEntity
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return this.sourceEntity_0;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				this.sourceEntity_0 = value;
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06002327 RID: 8999 RVA: 0x000651E4 File Offset: 0x000633E4
		// (set) Token: 0x06002328 RID: 9000 RVA: 0x000651EC File Offset: 0x000633EC
		public virtual string Name
		{
			get
			{
				return this.string_0;
			}
			set
			{
				if (this.string_0 != value)
				{
					this.string_0 = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06002329 RID: 9001 RVA: 0x00065210 File Offset: 0x00063410
		// (set) Token: 0x0600232A RID: 9002 RVA: 0x00065218 File Offset: 0x00063418
		public string ResourcePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return this.string_1;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				this.string_1 = value;
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x0600232B RID: 9003 RVA: 0x00065224 File Offset: 0x00063424
		// (set) Token: 0x0600232C RID: 9004 RVA: 0x0006522C File Offset: 0x0006342C
		public string ModulePath
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return this.string_2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				this.string_2 = value;
			}
		}

		// Token: 0x0600232D RID: 9005 RVA: 0x00065238 File Offset: 0x00063438
		public SourceEntity()
		{
			this.propertyChangedEventHandler_0 = new global::System.ComponentModel.PropertyChangedEventHandler(global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity.T__LT_MT_c.F__LT_MT_9.M__LT_DT_ctor_MT_b_16_0);
			//base..ctor();
		}

		// Token: 0x0600232E RID: 9006 RVA: 0x00065268 File Offset: 0x00063468
		public SourceEntity(string name)
		{
			this.propertyChangedEventHandler_0 = new global::System.ComponentModel.PropertyChangedEventHandler(global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity.T__LT_MT_c.F__LT_MT_9.M__LT_DT_ctor_MT_b_17_0);
			//base..ctor();
			this.Name = name;
		}

		// Token: 0x0600232F RID: 9007 RVA: 0x0006529C File Offset: 0x0006349C
		public SourceEntity(global::Mono.Cecil.IMemberDefinition member)
		{
			this.propertyChangedEventHandler_0 = new global::System.ComponentModel.PropertyChangedEventHandler(global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity.T__LT_MT_c.F__LT_MT_9.M__LT_DT_ctor_MT_b_18_0);
			//base..ctor();
			this.ModulePath = ((member is global::Mono.Cecil.TypeReference) ? (member as global::Mono.Cecil.TypeReference).Module.FilePath : member.DeclaringType.Module.FilePath);
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00065304 File Offset: 0x00063504
		public SourceEntity(string name, global::Mono.Cecil.IMemberDefinition member)
			: this(member)
		{
			this.Name = name;
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06002331 RID: 9009 RVA: 0x00065314 File Offset: 0x00063514
		public virtual global::nsMorello.Enum8 EntityKind
		{
			get
			{
				return global::nsMorello.Enum8.const_0;
			}
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x00065318 File Offset: 0x00063518
		protected virtual void OnPropertyChanged(string string_3)
		{
			this.propertyChangedEventHandler_0(this, new global::System.ComponentModel.PropertyChangedEventArgs(string_3));
		}

		// Token: 0x14000098 RID: 152
		// (add) Token: 0x06002333 RID: 9011 RVA: 0x0006532C File Offset: 0x0006352C
		// (remove) Token: 0x06002334 RID: 9012 RVA: 0x00065364 File Offset: 0x00063564
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler3 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Combine(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, propertyChangedEventHandler3, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler = this.propertyChangedEventHandler_0;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler2;
				do
				{
					propertyChangedEventHandler2 = propertyChangedEventHandler;
					global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler3 = (global::System.ComponentModel.PropertyChangedEventHandler)global::System.Delegate.Remove(propertyChangedEventHandler2, value);
					propertyChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.ComponentModel.PropertyChangedEventHandler>(ref this.propertyChangedEventHandler_0, propertyChangedEventHandler3, propertyChangedEventHandler2);
				}
				while (propertyChangedEventHandler != propertyChangedEventHandler2);
			}
		}

		// Token: 0x04000D33 RID: 3379
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity sourceEntity_0;

		// Token: 0x04000D34 RID: 3380
		private string string_0;

		// Token: 0x04000D35 RID: 3381
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string string_1;

		// Token: 0x04000D36 RID: 3382
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string string_2;

		// Token: 0x04000D37 RID: 3383
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.ComponentModel.PropertyChangedEventHandler propertyChangedEventHandler_0;

		// Token: 0x0200042A RID: 1066
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::System.Serializable]
		private sealed class T__LT_MT_c
		{
			// Token: 0x06002335 RID: 9013 RVA: 0x0006539C File Offset: 0x0006359C
			// Note: this type is marked as 'beforefieldinit'.
			static T__LT_MT_c()
			{
			}

			// Token: 0x06002336 RID: 9014 RVA: 0x000653A8 File Offset: 0x000635A8
			public T__LT_MT_c()
			{
			}

			// Token: 0x06002337 RID: 9015 RVA: 0x000653B0 File Offset: 0x000635B0
			internal void M__LT_DT_ctor_MT_b_16_0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
			}

			// Token: 0x06002338 RID: 9016 RVA: 0x000653B4 File Offset: 0x000635B4
			internal void M__LT_DT_ctor_MT_b_17_0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
			}

			// Token: 0x06002339 RID: 9017 RVA: 0x000653B8 File Offset: 0x000635B8
			internal void M__LT_DT_ctor_MT_b_18_0(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
			{
			}

			// Token: 0x04000D38 RID: 3384
			public static readonly global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity.T__LT_MT_c F__LT_MT_9 = new global::JustDecompile.FindUsages.ViewModels.Entities.SourceEntity.T__LT_MT_c();

			// Token: 0x04000D39 RID: 3385
			public static global::System.ComponentModel.PropertyChangedEventHandler F__LT_MT_9_16_0;

			// Token: 0x04000D3A RID: 3386
			public static global::System.ComponentModel.PropertyChangedEventHandler F__LT_MT_9_17_0;

			// Token: 0x04000D3B RID: 3387
			public static global::System.ComponentModel.PropertyChangedEventHandler F__LT_MT_9_18_0;
		}
	}
}
