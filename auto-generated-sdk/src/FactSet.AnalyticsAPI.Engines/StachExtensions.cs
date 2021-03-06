﻿using System;
using System.Collections.Generic;
using System.Linq;
using FactSet.Protobuf.Stach;
using FactSet.Protobuf.Stach.Table;

namespace FactSet.AnalyticsAPI.Engines
{
    /// <summary>
    /// The purpose of this class is to provide the helper methods for converting stach to Tabular format.
    /// </summary>
    public static class StachExtensions
    {
        /// <summary>
        /// The purpose of this function is to convert stach to Tabular format.
        /// </summary>
        /// <param name="package"></param>
        /// <returns>Returns a list of tables for a given stach data.</returns>
        public static List<Table> ConvertToTableFormat(this Package package)
        {
            var tables = new List<Table>();
            foreach (var primaryTableId in package.PrimaryTableIds)
            {
                tables.Add(GenerateTable(package, primaryTableId));
            }

            return tables;
        }

        /// <summary>
        /// The purpose of this function is to generate Table for a given table id in the provided
        /// stach data through the package.
        /// </summary>
        /// <param name="package"></param>
        /// <param name="primaryTableId"></param>
        /// <returns>Returns the generated Table from the package provided.</returns>
        private static Table GenerateTable(Package package, string primaryTableId)
        {
            var primaryTable = package.Tables[primaryTableId];
            var headerId = primaryTable.Definition.HeaderTableId;
            var headerTable = package.Tables[headerId];
            var columnIds = primaryTable.Definition.Columns.Select(c => c.Id).ToList();
            var headerColumnIds = headerTable.Definition.Columns.Select(c => c.Id).ToList();
            var dimensionColumnsCount = primaryTable.Definition.Columns.Count(c => c.IsDimension);
            var rowCount = primaryTable.Data.Rows.Count;
            var headerRowCount = headerTable.Data.Rows.Count;

            var table = new Table
            {
                Rows = new List<Row>(),
                Metadata = new Dictionary<string, string>()
            };
            // Constructs the column headers by considering dimension columns and header rows
            foreach (var columnId in headerColumnIds)
            {
                var headerRow = new Row { Cells = new List<string>() };
                for (int j = 0; j < dimensionColumnsCount; j++)
                {
                    headerRow.Cells.Add("");
                }

                for (int i = 0; i < headerRowCount; i++)
                {
                    headerRow.Cells.Add(Convert.ToString(headerTable.Data.Columns[columnId]
                        .GetValueHelper(headerTable.Definition.Columns.First(c => c.Id == columnId).Type, i)));
                }
                headerRow.isHeader = true;
                table.Rows.Add(headerRow);
            }
            // Constructs the column data
            for (int i = 0; i < rowCount; i++)
            {
                var dataRow = new Row { Cells = new List<string>() };
                foreach (var columnId in columnIds)
                {
                    dataRow.Cells.Add(Convert.ToString(primaryTable.Data.Columns[columnId]
                        .GetValueHelper(primaryTable.Definition.Columns.First(c => c.Id == columnId).Type, i)));
                }
                table.Rows.Add(dataRow);
            }

            var metadataItems = primaryTable.Data.Metadata.Items;
            var tableMetadataLocations = primaryTable.Data.Metadata.Locations.Table;

            foreach (var location in tableMetadataLocations)
            {
                table.Metadata.Add(metadataItems[location].Name, metadataItems[location].StringValue);
            }

            return table;
        }
    }

    /// <summary>
    /// This class provides helper method for returning the data from the SeriesData object by handling the null values.
    /// </summary>
    internal static class SeriesDataHelper
    {
        /// <summary>
        /// The purpose of this function is to return the value from the provided SeriesData object.
        /// </summary>
        /// <exception cref="NotImplementedException">Thrown when datatype is not implemented</exception>
        /// <param name="seriesData"></param>
        /// <param name="dataType"></param>
        /// <param name="index"></param>
        /// <returns>Return data object from the SeriesData.</returns>
        public static object GetValueHelper(this SeriesData seriesData, DataType dataType, int index)
        {
            switch (dataType)
            {
                case DataType.Bool:
                    {
                        return seriesData.BoolArray?.Values?[index];
                    }
                case DataType.Double:
                    {
                        return seriesData.DoubleArray?.Values?[index];
                    }
                case DataType.Duration:
                    {
                        var v = seriesData.DurationArray?.Values?[index];
                        return v?.ToTimeSpan();
                    }
                case DataType.Float:
                    {
                        return seriesData.FloatArray?.Values?[index];
                    }
                case DataType.Int32:
                    {
                        return seriesData.Int32Array?.Values?[index];
                    }
                case DataType.Int64:
                    {
                        return seriesData.Int64Array?.Values?[index];
                    }
                case DataType.String:
                    {
                        return seriesData.StringArray?.Values?[index];
                    }
                case DataType.Timestamp:
                    {
                        var v = seriesData.TimestampArray?.Values?[index];
                        return v?.ToDateTime();
                    }
                default:
                    throw new NotImplementedException($"{dataType} is not implemented");
            }
        }
    }

    /// <summary>
    /// Represents the custom model class for Tables to be generated from stach data.
    /// </summary>
    public class Table
    {
        /// <summary>
        /// Gets or sets the Row object.
        /// </summary>
        public List<Row> Rows { get; set; }

        /// <summary>
        /// Metadata of the table.
        /// </summary>
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The purpose of this function is to concatenate member of Row array with specified separator between each member i.e a newline.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Join(Environment.NewLine, Rows);
        }
    }

    /// <summary>
    /// Represents the custom model class for the Rows inside the generated tables.
    /// </summary>
    public class Row
    {
        /// <summary>
        /// Gets or sets the Cells object.
        /// </summary>
        public List<string> Cells { get; set; }

        /// <summary>
        /// To know whether a row is a header row.
        /// </summary>
        public bool isHeader { get; set; }

        /// <summary>
        /// The purpose of this function is to concatenate member of Cell array with specified separator between each member i.e ",".
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return string.Join(",", Cells.Select(c => c.Replace(",", "")));
        }
    }
}