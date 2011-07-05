﻿/*
Copyright (c) 2011 <a href="http://www.gutgames.com">James Craig</a>

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.*/

#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using Utilities.DataTypes.Patterns;
using Utilities.ORM.QueryProviders.Interfaces;
using Utilities.SQL.MicroORM;
#endregion

namespace Utilities.ORM.Mapping.Interfaces
{
    /// <summary>
    /// Property interface
    /// </summary>
    public interface IProperty
    {
        #region Properties

        /// <summary>
        /// Auto increment
        /// </summary>
        bool AutoIncrement { get; }

        /// <summary>
        /// Cascade
        /// </summary>
        bool Cascade { get; }

        /// <summary>
        /// Derived field name
        /// </summary>
        string DerivedFieldName { get; }

        /// <summary>
        /// Field name
        /// </summary>
        string FieldName { get; }

        /// <summary>
        /// Foreign key link
        /// </summary>
        IMapping ForeignKey { get; set; }

        /// <summary>
        /// Index
        /// </summary>
        bool Index { get; }

        /// <summary>
        /// Max length (used in strings)
        /// </summary>
        int MaxLength { get; }

        /// <summary>
        /// Name of the property
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Can the item be null?
        /// </summary>
        bool NotNull { get; }

        /// <summary>
        /// Table name
        /// </summary>
        string TableName { get; }

        /// <summary>
        /// Property type
        /// </summary>
        Type Type { get; }

        /// <summary>
        /// Is this a unique field?
        /// </summary>
        bool Unique { get; }

        #endregion
    }
    
    /// <summary>
    /// Property interface
    /// </summary>
    /// <typeparam name="ClassType">Class type</typeparam>
    public interface IProperty<ClassType>
        where ClassType : class,new()
    {
        #region Functions

        /// <summary>
        /// Adds to query provider
        /// </summary>
        /// <param name="Database">Database associated with mapping</param>
        /// <param name="Mapping">Mapping to add the property to</param>
        /// <typeparam name="ClassType">Class type</typeparam>
        void AddToQueryProvider(IDatabase Database, Mapping<ClassType> Mapping);

        #endregion
    }

    /// <summary>
    /// Property interface
    /// </summary>
    public interface IProperty<ClassType, DataType>
    {
        #region Properties

        /// <summary>
        /// Default value for this property
        /// </summary>
        Func<DataType> DefaultValue { get; }

        /// <summary>
        /// Expression pointing to the property
        /// </summary>
        Expression<Func<ClassType, DataType>> Expression { get; }

        #endregion
    }

    /// <summary>
    /// Property interface
    /// </summary>
    /// <typeparam name="ClassType">Class type</typeparam>
    /// <typeparam name="DataType">Data type of the property</typeparam>
    /// <typeparam name="ReturnType">Return type</typeparam>
    public interface IProperty<ClassType, DataType, ReturnType> : IFluentInterface
    {
        #region Functions

        /// <summary>
        /// Sets the default value of the property
        /// </summary>
        /// <param name="DefaultValue">Default value</param>
        /// <returns>This IProperty object</returns>
        ReturnType SetDefaultValue(Func<DataType> DefaultValue);

        /// <summary>
        /// Sets the field to not null
        /// </summary>
        /// <returns>this</returns>
        ReturnType DoNotAllowNullValues();

        /// <summary>
        /// Sets the unique field to true
        /// </summary>
        /// <returns>this</returns>
        ReturnType ThisShouldBeUnique();

        /// <summary>
        /// Turns on indexing for this property
        /// </summary>
        /// <returns>This</returns>
        ReturnType TurnOnIndexing();

        /// <summary>
        /// Turns on autoincrement for this property
        /// </summary>
        /// <returns>This</returns>
        ReturnType TurnOnAutoIncrement();

        /// <summary>
        /// Sets the name of the field in the database
        /// </summary>
        /// <param name="FieldName">Field name</param>
        /// <returns>this</returns>
        ReturnType SetFieldName(string FieldName);

        /// <summary>
        /// Set database table name
        /// </summary>
        /// <param name="TableName">Table name</param>
        /// <returns>this</returns>
        ReturnType SetTableName(string TableName);

        /// <summary>
        /// Turns on cascade for saving/deleting
        /// </summary>
        /// <returns>this</returns>
        ReturnType TurnOnCascade();

        /// <summary>
        /// Sets the max length for the string
        /// </summary>
        /// <param name="MaxLength">Max length</param>
        /// <returns>this</returns>
        ReturnType SetMaxLength(int MaxLength);

        #endregion
    }
}
