// This file is used by Code Analysis to maintain SuppressMessage 
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given 
// a specific target and scoped to a namespace, type, member, etc.
//
// To add a suppression to this file, right-click the message in the 
// Code Analysis results, point to "Suppress Message", and click 
// "In Suppression File".
// You do not need to add suppressions to this file manually.

[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2211:NonConstantFieldsShouldNotBeVisible", Scope = "member", Target = "Ironman.Core.AppHelper.#Bootstrapper")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Ironman.Core.Assets.Asset.#Included")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1002:DoNotExposeGenericLists", Scope = "member", Target = "Ironman.Core.Assets.AssetManager.#RunOrder")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.AutoRefresh")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.ByPassCRSF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.ClientSideCache")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.Compress")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors", Scope = "member", Target = "Ironman.Core.ActionFilters.Compress.#.ctor()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.ContentType")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Ironman.Core.BaseClasses.ControllerBase.#DirectoryInfo(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Ironman.Core.BaseClasses.ControllerBase.#FileInfo(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Ironman.Core.BaseClasses.ControllerBase.#StartProfiling(System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.CSRF")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1822:MarkMembersAsStatic", Scope = "member", Target = "Ironman.Core.ActionFilters.CSRF.#ShouldValidate(System.Web.Mvc.AuthorizationContext)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.DoNotCompress")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.BaseClasses.HttpApplicationBase.#Application_AuthenticateRequest(System.Object,System.EventArgs)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.BaseClasses.HttpApplicationBase.#Application_BeginRequest()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.BaseClasses.HttpApplicationBase.#Application_EndRequest()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.BaseClasses.HttpApplicationBase.#Application_Error()")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Ironman.Core.Assets.Interfaces.IAsset.#Included")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1056:UriPropertiesShouldNotBeStrings", Scope = "member", Target = "Ironman.Core.Assets.Interfaces.IAsset.#URL")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.RequireSSL")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.ResponseHeader")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Ironman.Core.BaseClasses.ControllerBase.#Serialize`1(!!0,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Ironman.Core.Assets.AssetManager.#Process(System.Collections.Generic.IList`1<Ironman.Core.Assets.Interfaces.IAsset>,System.Web.Optimization.BundleResponse)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#SetAll(System.Func`1<System.Collections.Generic.IEnumerable`1<!0>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.BaseClasses.APIPropertyBaseClass`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Ironman.Core.API.Manager.BaseClasses.APIPropertyBaseClass`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#ID`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#Map`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#Reference`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,!!0>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Ironman.Core.API.Manager.Interfaces.IAPIProperty`1")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Properties.ID`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Ironman.Core.API.Manager.Interfaces.IID")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Ironman.Core.API.Manager.Interfaces.IMap")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Ironman.Core.API.Manager.Interfaces.IReference")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#All(System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Any(System.String,System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Delete(System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.String,Utilities.DataTypes.Dynamo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Properties.Map`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Properties.Reference`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,!1>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1040:AvoidEmptyInterfaces", Scope = "type", Target = "Ironman.Core.API.Manager.Interfaces.IAPIProperty`2")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1023:IndexersShouldNotBeMultidimensional", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Item[System.Int32,System.String]")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#All(System.Int32,System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Any(System.Int32,System.String,System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Delete(System.Int32,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.Int32,System.String,Utilities.DataTypes.Dynamo)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly", Scope = "member", Target = "Ironman.Core.API.Manager.MappingHolder.#Mappings")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Properties.MapList`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Collections.Generic.IEnumerable`1<!1>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Properties.MapList`2.#.ctor(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Collections.Generic.IEnumerable`1<!1>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#SaveProperty(System.Int32,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#SaveProperty(System.Int32,System.String,System.String,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.Int32,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.Int32,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.Int32,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "2", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#Save(System.Int32,System.String,System.Collections.Generic.IEnumerable`1<Utilities.DataTypes.Dynamo>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#GetProperty(System.Int32,System.String,System.String,System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#DeleteProperty(System.Int32,System.String,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#DeleteProperty(System.Int32,System.String,System.String,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#GetProperty(System.Int32,System.String,System.String,System.String,System.String[])")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#MapList`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Collections.Generic.IEnumerable`1<!!0>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#AllFunc")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#AllFunc")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1006:DoNotNestGenericTypesInMemberSignatures", Scope = "member", Target = "Ironman.Core.API.Manager.Interfaces.IAPIMapping`1.#MapList`1(System.Linq.Expressions.Expression`1<System.Func`2<!0,System.Collections.Generic.IEnumerable`1<!!0>>>)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1813:AvoidUnsealedAttributes", Scope = "type", Target = "Ironman.Core.ActionFilters.DeserializationFilter")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1026:DefaultParametersShouldNotBeUsed", Scope = "member", Target = "Ironman.Core.API.Manager.Manager.#RegisterRoutes(System.Web.Routing.RouteCollection,System.String,System.String)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "1", Scope = "member", Target = "Ironman.Core.Assets.Asset.#.ctor(System.String,Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1062:Validate arguments of public methods", MessageId = "0", Scope = "member", Target = "Ironman.Core.Assets.Transformers.Transformer.#.ctor(Utilities.IoC.Interfaces.IBootstrapper)")]
[assembly: System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode", Scope = "member", Target = "Ironman.Core.Assets.Transformers.Transformer.#Bootstrapper")]
