// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.PresentationAppearanceResource;

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcTextStyleTextModel
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcTextStyleTextModel : IPersistEntity, IfcTextStyleSelect
	{
		IfcSizeSelect @TextIndent { get; }
		IfcTextAlignment? @TextAlign { get; }
		IfcTextDecoration? @TextDecoration { get; }
		IfcSizeSelect @LetterSpacing { get; }
		IfcSizeSelect @WordSpacing { get; }
		IfcTextTransformation? @TextTransform { get; }
		IfcSizeSelect @LineHeight { get; }
		
	}
}

namespace Xbim.Ifc2x3.PresentationAppearanceResource
{
	[IndexedClass]
	[ExpressType("IFCTEXTSTYLETEXTMODEL", 581)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleTextModel : INotifyPropertyChanged, IInstantiableEntity, IIfcTextStyleTextModel, IEqualityComparer<@IfcTextStyleTextModel>, IEquatable<@IfcTextStyleTextModel>
	{
		#region IIfcTextStyleTextModel explicit implementation
		IfcSizeSelect IIfcTextStyleTextModel.TextIndent { get { return @TextIndent; } }	
		IfcTextAlignment? IIfcTextStyleTextModel.TextAlign { get { return @TextAlign; } }	
		IfcTextDecoration? IIfcTextStyleTextModel.TextDecoration { get { return @TextDecoration; } }	
		IfcSizeSelect IIfcTextStyleTextModel.LetterSpacing { get { return @LetterSpacing; } }	
		IfcSizeSelect IIfcTextStyleTextModel.WordSpacing { get { return @WordSpacing; } }	
		IfcTextTransformation? IIfcTextStyleTextModel.TextTransform { get { return @TextTransform; } }	
		IfcSizeSelect IIfcTextStyleTextModel.LineHeight { get { return @LineHeight; } }	
		 
		#endregion

		#region Implementation of IPersistEntity

		public int EntityLabel {get; internal set;}
		
		public IModel Model { get; internal set; }

		/// <summary>
        /// This property is deprecated and likely to be removed. Use just 'Model' instead.
        /// </summary>
		[Obsolete("This property is deprecated and likely to be removed. Use just 'Model' instead.")]
        public IModel ModelOf { get { return Model; } }
		
	    internal ActivationStatus ActivationStatus = ActivationStatus.NotActivated;

	    ActivationStatus IPersistEntity.ActivationStatus { get { return ActivationStatus; } }
		
		void IPersistEntity.Activate(bool write)
		{
			switch (ActivationStatus)
		    {
		        case ActivationStatus.ActivatedReadWrite:
		            return;
		        case ActivationStatus.NotActivated:
		            lock (this)
		            {
                        //check again in the lock
		                if (ActivationStatus == ActivationStatus.NotActivated)
		                {
		                    if (Model.Activate(this, write))
		                    {
		                        ActivationStatus = write
		                            ? ActivationStatus.ActivatedReadWrite
		                            : ActivationStatus.ActivatedRead;
		                    }
		                }
		            }
		            break;
		        case ActivationStatus.ActivatedRead:
		            if (!write) return;
		            if (Model.Activate(this, true))
                        ActivationStatus = ActivationStatus.ActivatedReadWrite;
		            break;
		        default:
		            throw new ArgumentOutOfRangeException();
		    }
		}

		void IPersistEntity.Activate (Action activation)
		{
			if (ActivationStatus != ActivationStatus.NotActivated) return; //activation can only happen once in a lifetime of the object
			
			activation();
			ActivationStatus = ActivationStatus.ActivatedRead;
		}

		ExpressType IPersistEntity.ExpressType { get { return Model.Metadata.ExpressType(this);  } }
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleTextModel(IModel model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcSizeSelect _textIndent;
		private IfcTextAlignment? _textAlign;
		private IfcTextDecoration? _textDecoration;
		private IfcSizeSelect _letterSpacing;
		private IfcSizeSelect _wordSpacing;
		private IfcTextTransformation? _textTransform;
		private IfcSizeSelect _lineHeight;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @TextIndent 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textIndent;
				((IPersistEntity)this).Activate(false);
				return _textIndent;
			} 
			set
			{
				SetValue( v =>  _textIndent = v, _textIndent, value,  "TextIndent");
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextAlignment? @TextAlign 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textAlign;
				((IPersistEntity)this).Activate(false);
				return _textAlign;
			} 
			set
			{
				SetValue( v =>  _textAlign = v, _textAlign, value,  "TextAlign");
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextDecoration? @TextDecoration 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textDecoration;
				((IPersistEntity)this).Activate(false);
				return _textDecoration;
			} 
			set
			{
				SetValue( v =>  _textDecoration = v, _textDecoration, value,  "TextDecoration");
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @LetterSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _letterSpacing;
				((IPersistEntity)this).Activate(false);
				return _letterSpacing;
			} 
			set
			{
				SetValue( v =>  _letterSpacing = v, _letterSpacing, value,  "LetterSpacing");
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @WordSpacing 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _wordSpacing;
				((IPersistEntity)this).Activate(false);
				return _wordSpacing;
			} 
			set
			{
				SetValue( v =>  _wordSpacing = v, _wordSpacing, value,  "WordSpacing");
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1)]
		public IfcTextTransformation? @TextTransform 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _textTransform;
				((IPersistEntity)this).Activate(false);
				return _textTransform;
			} 
			set
			{
				SetValue( v =>  _textTransform = v, _textTransform, value,  "TextTransform");
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1)]
		public IfcSizeSelect @LineHeight 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _lineHeight;
				((IPersistEntity)this).Activate(false);
				return _lineHeight;
			} 
			set
			{
				SetValue( v =>  _lineHeight = v, _lineHeight, value,  "LineHeight");
			} 
		}	
		#endregion



		#region INotifyPropertyChanged implementation
		 
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged( string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

		#endregion

		#region Transactional property setting

		protected void SetValue<TProperty>(Action<TProperty> setter, TProperty oldValue, TProperty newValue, string notifyPropertyName)
		{
			//activate for write if it is not activated yet
			if (ActivationStatus != ActivationStatus.ActivatedReadWrite)
				((IPersistEntity)this).Activate(true);

			//just set the value if the model is marked as non-transactional
			if (!Model.IsTransactional)
			{
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
				return;
			}

			//check there is a transaction
			var txn = Model.CurrentTransaction;
			if (txn == null) throw new Exception("Operation out of transaction.");

			Action doAction = () => {
				setter(newValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			Action undoAction = () => {
				setter(oldValue);
				NotifyPropertyChanged(notifyPropertyName);
			};
			doAction();

			//do action and THAN add to transaction so that it gets the object in new state
			txn.AddReversibleAction(doAction, undoAction, this, ChangeType.Modified);
		}

		#endregion

		#region IPersist implementation
		public virtual void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_textIndent = (IfcSizeSelect)(value.EntityVal);
					return;
				case 1: 
					_textAlign = value.StringVal;
					return;
				case 2: 
					_textDecoration = value.StringVal;
					return;
				case 3: 
					_letterSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 4: 
					_wordSpacing = (IfcSizeSelect)(value.EntityVal);
					return;
				case 5: 
					_textTransform = value.StringVal;
					return;
				case 6: 
					_lineHeight = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		
		public virtual string WhereRule() 
		{
			return "";
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyleTextModel other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcTextStyleTextModel
            var root = (@IfcTextStyleTextModel)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcTextStyleTextModel left, @IfcTextStyleTextModel right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcTextStyleTextModel left, @IfcTextStyleTextModel right)
        {
            return !(left == right);
        }


        public bool Equals(@IfcTextStyleTextModel x, @IfcTextStyleTextModel y)
        {
            return x == y;
        }

        public int GetHashCode(@IfcTextStyleTextModel obj)
        {
            return obj == null ? -1 : obj.GetHashCode();
        }
        #endregion
	}
}