﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightSwitchApplication
{
    #region Entities
    
    /// <summary>
    /// No Modeled Description Available
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
    public sealed partial class Semestar : global::Microsoft.LightSwitch.Framework.Base.EntityObject<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new instance of the Semestar entity.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Semestar()
            : this(null)
        {
        }
    
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Semestar(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Semestar> entitySet)
            : base(entitySet)
        {
            global::LightSwitchApplication.Semestar.DetailsClass.Initialize(this);
        }
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Semestar_Created();
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Semestar_AllowSaveWithErrors(ref bool result);
    
        #endregion
    
        #region Private Properties
        
        /// <summary>
        /// Gets the Application object for this application.  The Application object provides access to active screens, methods to open screens and access to the current user.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace> Application
        {
            get
            {
                return (global::Microsoft.LightSwitch.IApplication<global::LightSwitchApplication.DataWorkspace>)global::LightSwitchApplication.Application.Current;
            }
        }
        
        /// <summary>
        /// Gets the containing data workspace.  The data workspace provides access to all data sources in the application.
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private global::LightSwitchApplication.DataWorkspace DataWorkspace
        {
            get
            {
                return (global::LightSwitchApplication.DataWorkspace)this.Details.EntitySet.Details.DataService.Details.DataWorkspace;
            }
        }
        
        #endregion
    
        #region Public Properties
    
        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public int ID_semestar
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.ID_semestar);
            }
            set
            {
                global::LightSwitchApplication.Semestar.DetailsClass.SetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.ID_semestar, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ID_semestar_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ID_semestar_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void ID_semestar_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Nullable<int> Br_semestar
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Br_semestar);
            }
            set
            {
                global::LightSwitchApplication.Semestar.DetailsClass.SetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Br_semestar, value);
            }
        }
        
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Br_semestar_IsReadOnly(ref bool result);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Br_semestar_Validate(global::Microsoft.LightSwitch.EntityValidationResultsBuilder results);
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        partial void Br_semestar_Changed();

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Predmet> Predmets
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Predmets);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Predmet> PredmetsQuery
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetQuery(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Predmets);
            }
        }

        /// <summary>
        /// No Modeled Description Available
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.LightSwitch.Framework.EntityCollection<global::LightSwitchApplication.Student> Students
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetValue(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Students);
            }
        }
        
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public Microsoft.LightSwitch.IDataServiceQueryable<global::LightSwitchApplication.Student> StudentsQuery
        {
            get
            {
                return global::LightSwitchApplication.Semestar.DetailsClass.GetQuery(this, global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Students);
            }
        }

        #endregion
    
        #region Details Class
    
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public sealed class DetailsClass : global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<
                global::LightSwitchApplication.Semestar,
                global::LightSwitchApplication.Semestar.DetailsClass,
                global::LightSwitchApplication.Semestar.DetailsClass.IImplementation,
                global::LightSwitchApplication.Semestar.DetailsClass.PropertySet,
                global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>,
                global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>>
        {
    
            static DetailsClass()
            {
                var initializeEntry = global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.ID_semestar;
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private static readonly global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>.Entry
                __SemestarEntry = new global::Microsoft.LightSwitch.Details.Framework.Base.EntityDetails<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>.Entry(
                    global::LightSwitchApplication.Semestar.DetailsClass.__Semestar_CreateNew,
                    global::LightSwitchApplication.Semestar.DetailsClass.__Semestar_Created,
                    global::LightSwitchApplication.Semestar.DetailsClass.__Semestar_AllowSaveWithErrors);
            private static global::LightSwitchApplication.Semestar __Semestar_CreateNew(global::Microsoft.LightSwitch.Framework.EntitySet<global::LightSwitchApplication.Semestar> es)
            {
                return new global::LightSwitchApplication.Semestar(es);
            }
            private static void __Semestar_Created(global::LightSwitchApplication.Semestar e)
            {
                e.Semestar_Created();
            }
            private static bool __Semestar_AllowSaveWithErrors(global::LightSwitchApplication.Semestar e)
            {
                bool result = false;
                e.Semestar_AllowSaveWithErrors(ref result);
                return result;
            }
    
            public DetailsClass() : base()
            {
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityCommandSet<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass> Commands
            {
                get
                {
                    return base.Commands;
                }
            }
    
            public new global::Microsoft.LightSwitch.Details.Framework.EntityMethodSet<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass> Methods
            {
                get
                {
                    return base.Methods;
                }
            }
    
            public new global::LightSwitchApplication.Semestar.DetailsClass.PropertySet Properties
            {
                get
                {
                    return base.Properties;
                }
            }
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            public sealed class PropertySet : global::Microsoft.LightSwitch.Details.Framework.Base.EntityPropertySet<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass>
            {
    
                public PropertySet() : base()
                {
                }
    
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int> ID_semestar
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.ID_semestar) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>> Br_semestar
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Br_semestar) as global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet> Predmets
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Predmets) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet>;
                    }
                }
                
                public global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student> Students
                {
                    get
                    {
                        return base.GetItem(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Students) as global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student>;
                    }
                }
                
            }
    
            #pragma warning disable 109
            [global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
            public interface IImplementation : global::Microsoft.LightSwitch.Internal.IEntityImplementation
            {
                new int ID_semestar { get; set; }
                new global::System.Nullable<int> Br_semestar { get; set; }
                new global::System.Collections.IEnumerable Predmets { get; }
                new global::System.Collections.IEnumerable Students { get; }
            }
            #pragma warning restore 109
    
            [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.LightSwitch.BuildTasks.CodeGen", "12.1.0.0")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            internal class PropertySetProperties
            {
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int>.Entry
                    ID_semestar = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int>.Entry(
                        "ID_semestar",
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_Stub,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_ComputeIsReadOnly,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_Validate,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_GetImplementationValue,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_SetImplementationValue,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._ID_semestar_OnValueChanged);
                private static void _ID_semestar_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Semestar.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int>.Data> c, global::LightSwitchApplication.Semestar.DetailsClass d, object sf)
                {
                    c(d, ref d._ID_semestar, sf);
                }
                private static bool _ID_semestar_ComputeIsReadOnly(global::LightSwitchApplication.Semestar e)
                {
                    bool result = false;
                    e.ID_semestar_IsReadOnly(ref result);
                    return result;
                }
                private static void _ID_semestar_Validate(global::LightSwitchApplication.Semestar e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.ID_semestar_Validate(r);
                }
                private static int _ID_semestar_GetImplementationValue(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.ImplementationEntity.ID_semestar;
                }
                private static void _ID_semestar_SetImplementationValue(global::LightSwitchApplication.Semestar.DetailsClass d, int v)
                {
                    d.ImplementationEntity.ID_semestar = v;
                }
                private static void _ID_semestar_OnValueChanged(global::LightSwitchApplication.Semestar e)
                {
                    e.ID_semestar_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>>.Entry
                    Br_semestar = new global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>>.Entry(
                        "Br_semestar",
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_Stub,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_ComputeIsReadOnly,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_Validate,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_GetImplementationValue,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_SetImplementationValue,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Br_semestar_OnValueChanged);
                private static void _Br_semestar_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Semestar.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>>.Data> c, global::LightSwitchApplication.Semestar.DetailsClass d, object sf)
                {
                    c(d, ref d._Br_semestar, sf);
                }
                private static bool _Br_semestar_ComputeIsReadOnly(global::LightSwitchApplication.Semestar e)
                {
                    bool result = false;
                    e.Br_semestar_IsReadOnly(ref result);
                    return result;
                }
                private static void _Br_semestar_Validate(global::LightSwitchApplication.Semestar e, global::Microsoft.LightSwitch.EntityValidationResultsBuilder r)
                {
                    e.Br_semestar_Validate(r);
                }
                private static global::System.Nullable<int> _Br_semestar_GetImplementationValue(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.ImplementationEntity.Br_semestar;
                }
                private static void _Br_semestar_SetImplementationValue(global::LightSwitchApplication.Semestar.DetailsClass d, global::System.Nullable<int> v)
                {
                    d.ImplementationEntity.Br_semestar = v;
                }
                private static void _Br_semestar_OnValueChanged(global::LightSwitchApplication.Semestar e)
                {
                    e.Br_semestar_Changed();
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet>.Entry
                    Predmets = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet>.Entry(
                        "Predmets",
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Predmets_Stub,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Predmets_GetReferencedEntities,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Predmets_GetEntityCollection);
                private static void _Predmets_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Semestar.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet>.Data> c, global::LightSwitchApplication.Semestar.DetailsClass d, object sf)
                {
                    c(d, ref d._Predmets, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Predmet> _Predmets_GetReferencedEntities(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Predmet, global::LightSwitchApplication.Predmet.DetailsClass>(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Predmets, ref d._Predmets);
                }
                private static global::System.Collections.IEnumerable _Predmets_GetEntityCollection(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.ImplementationEntity.Predmets;
                }
    
                [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
                public static readonly global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student>.Entry
                    Students = new global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student>.Entry(
                        "Students",
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Students_Stub,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Students_GetReferencedEntities,
                        global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties._Students_GetEntityCollection);
                private static void _Students_Stub(global::Microsoft.LightSwitch.Details.Framework.Base.DetailsCallback<global::LightSwitchApplication.Semestar.DetailsClass, global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student>.Data> c, global::LightSwitchApplication.Semestar.DetailsClass d, object sf)
                {
                    c(d, ref d._Students, sf);
                }
                private static global::System.Collections.Generic.IEnumerable<global::LightSwitchApplication.Student> _Students_GetReferencedEntities(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.GetReferencedEntities<global::LightSwitchApplication.Student, global::LightSwitchApplication.Student.DetailsClass>(global::LightSwitchApplication.Semestar.DetailsClass.PropertySetProperties.Students, ref d._Students);
                }
                private static global::System.Collections.IEnumerable _Students_GetEntityCollection(global::LightSwitchApplication.Semestar.DetailsClass d)
                {
                    return d.ImplementationEntity.Students;
                }
    
            }
    
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, int>.Data _ID_semestar;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityStorageProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::System.Nullable<int>>.Data _Br_semestar;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Predmet>.Data _Predmets;
            
            [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
            private global::Microsoft.LightSwitch.Details.Framework.EntityCollectionProperty<global::LightSwitchApplication.Semestar, global::LightSwitchApplication.Semestar.DetailsClass, global::LightSwitchApplication.Student>.Data _Students;
            
        }
    
        #endregion
    }
    
    #endregion
}