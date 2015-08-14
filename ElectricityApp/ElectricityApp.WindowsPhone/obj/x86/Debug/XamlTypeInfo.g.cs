﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace ElectricityApp
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[17];
            _typeNameTable[0] = "ElectricityApp.AddAppliancePage";
            _typeNameTable[1] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[2] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[3] = "ElectricityApp.AddMeterPage";
            _typeNameTable[4] = "ElectricityApp.CalculatorPage";
            _typeNameTable[5] = "ElectricityApp.CheckUnitsPage";
            _typeNameTable[6] = "ElectricityApp.ForgotPasswordPage";
            _typeNameTable[7] = "ElectricityApp.HistoryPage";
            _typeNameTable[8] = "ElectricityApp.MainPage1";
            _typeNameTable[9] = "String";
            _typeNameTable[10] = "ElectricityApp.RegisterPage";
            _typeNameTable[11] = "ElectricityApp.RemoveUserPage";
            _typeNameTable[12] = "ElectricityApp.UnitsPage";
            _typeNameTable[13] = "ElectricityApp.UnitsPage1";
            _typeNameTable[14] = "ElectricityApp.ViewAppliances";
            _typeNameTable[15] = "ElectricityApp.ViewPage";
            _typeNameTable[16] = "ElectricityApp.WelcomePage";

            _typeTable = new global::System.Type[17];
            _typeTable[0] = typeof(global::ElectricityApp.AddAppliancePage);
            _typeTable[1] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[2] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[3] = typeof(global::ElectricityApp.AddMeterPage);
            _typeTable[4] = typeof(global::ElectricityApp.CalculatorPage);
            _typeTable[5] = typeof(global::ElectricityApp.CheckUnitsPage);
            _typeTable[6] = typeof(global::ElectricityApp.ForgotPasswordPage);
            _typeTable[7] = typeof(global::ElectricityApp.HistoryPage);
            _typeTable[8] = typeof(global::ElectricityApp.MainPage1);
            _typeTable[9] = typeof(global::System.String);
            _typeTable[10] = typeof(global::ElectricityApp.RegisterPage);
            _typeTable[11] = typeof(global::ElectricityApp.RemoveUserPage);
            _typeTable[12] = typeof(global::ElectricityApp.UnitsPage);
            _typeTable[13] = typeof(global::ElectricityApp.UnitsPage1);
            _typeTable[14] = typeof(global::ElectricityApp.ViewAppliances);
            _typeTable[15] = typeof(global::ElectricityApp.ViewPage);
            _typeTable[16] = typeof(global::ElectricityApp.WelcomePage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_AddAppliancePage() { return new global::ElectricityApp.AddAppliancePage(); }
        private object Activate_3_AddMeterPage() { return new global::ElectricityApp.AddMeterPage(); }
        private object Activate_4_CalculatorPage() { return new global::ElectricityApp.CalculatorPage(); }
        private object Activate_5_CheckUnitsPage() { return new global::ElectricityApp.CheckUnitsPage(); }
        private object Activate_6_ForgotPasswordPage() { return new global::ElectricityApp.ForgotPasswordPage(); }
        private object Activate_7_HistoryPage() { return new global::ElectricityApp.HistoryPage(); }
        private object Activate_8_MainPage1() { return new global::ElectricityApp.MainPage1(); }
        private object Activate_10_RegisterPage() { return new global::ElectricityApp.RegisterPage(); }
        private object Activate_11_RemoveUserPage() { return new global::ElectricityApp.RemoveUserPage(); }
        private object Activate_12_UnitsPage() { return new global::ElectricityApp.UnitsPage(); }
        private object Activate_13_UnitsPage1() { return new global::ElectricityApp.UnitsPage1(); }
        private object Activate_14_ViewAppliances() { return new global::ElectricityApp.ViewAppliances(); }
        private object Activate_15_ViewPage() { return new global::ElectricityApp.ViewPage(); }
        private object Activate_16_WelcomePage() { return new global::ElectricityApp.WelcomePage(); }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  ElectricityApp.AddAppliancePage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_0_AddAppliancePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 3:   //  ElectricityApp.AddMeterPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_3_AddMeterPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 4:   //  ElectricityApp.CalculatorPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_4_CalculatorPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 5:   //  ElectricityApp.CheckUnitsPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_CheckUnitsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  ElectricityApp.ForgotPasswordPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_6_ForgotPasswordPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 7:   //  ElectricityApp.HistoryPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_7_HistoryPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 8:   //  ElectricityApp.MainPage1
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_8_MainPage1;
                userType.AddMemberName("DBPath");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  String
                xamlType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  ElectricityApp.RegisterPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_10_RegisterPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  ElectricityApp.RemoveUserPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_11_RemoveUserPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 12:   //  ElectricityApp.UnitsPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_UnitsPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  ElectricityApp.UnitsPage1
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_UnitsPage1;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 14:   //  ElectricityApp.ViewAppliances
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_14_ViewAppliances;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 15:   //  ElectricityApp.ViewPage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_15_ViewPage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 16:   //  ElectricityApp.WelcomePage
                userType = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_16_WelcomePage;
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_MainPage1_DBPath(object instance)
        {
            var that = (global::ElectricityApp.MainPage1)instance;
            return that.DBPath;
        }
        private void set_0_MainPage1_DBPath(object instance, object Value)
        {
            var that = (global::ElectricityApp.MainPage1)instance;
            that.DBPath = (global::System.String)Value;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlMember xamlMember = null;
            global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "ElectricityApp.MainPage1.DBPath":
                userType = (global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("ElectricityApp.MainPage1");
                xamlMember = new global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlMember(this, "DBPath", "String");
                xamlMember.Getter = get_0_MainPage1_DBPath;
                xamlMember.Setter = set_0_MainPage1_DBPath;
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlSystemBaseType
    {
        global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::ElectricityApp.ElectricityApp_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


