// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> A table object consisting table cells arranged in a rectangular layout. </summary>
    public partial class DocumentTable
    {
        /// <summary> Initializes a new instance of <see cref="DocumentTable"/>. </summary>
        /// <param name="rowCount"> Number of rows in the table. </param>
        /// <param name="columnCount"> Number of columns in the table. </param>
        /// <param name="cells"> Cells contained within the table. </param>
        /// <param name="spans"> Location of the table in the reading order concatenated content. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="cells"/> or <paramref name="spans"/> is null. </exception>
        internal DocumentTable(int rowCount, int columnCount, IEnumerable<DocumentTableCell> cells, IEnumerable<DocumentSpan> spans)
        {
            if (cells == null)
            {
                throw new ArgumentNullException(nameof(cells));
            }
            if (spans == null)
            {
                throw new ArgumentNullException(nameof(spans));
            }

            RowCount = rowCount;
            ColumnCount = columnCount;
            Cells = cells.ToList();
            BoundingRegions = new ChangeTrackingList<BoundingRegion>();
            Spans = spans.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="DocumentTable"/>. </summary>
        /// <param name="rowCount"> Number of rows in the table. </param>
        /// <param name="columnCount"> Number of columns in the table. </param>
        /// <param name="cells"> Cells contained within the table. </param>
        /// <param name="boundingRegions"> Bounding regions covering the table. </param>
        /// <param name="spans"> Location of the table in the reading order concatenated content. </param>
        internal DocumentTable(int rowCount, int columnCount, IReadOnlyList<DocumentTableCell> cells, IReadOnlyList<BoundingRegion> boundingRegions, IReadOnlyList<DocumentSpan> spans)
        {
            RowCount = rowCount;
            ColumnCount = columnCount;
            Cells = cells;
            BoundingRegions = boundingRegions;
            Spans = spans;
        }

        /// <summary> Number of rows in the table. </summary>
        public int RowCount { get; }
        /// <summary> Number of columns in the table. </summary>
        public int ColumnCount { get; }
        /// <summary> Cells contained within the table. </summary>
        public IReadOnlyList<DocumentTableCell> Cells { get; }
        /// <summary> Bounding regions covering the table. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the table in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
    }
}
