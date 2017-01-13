using System;
using PetaPoco;

namespace YamDocumentManagementSystem.Data.Entities.Filing.Color
{
    [ExplicitColumns, TableName(TableName), PrimaryKey(IdColumnName, AutoIncrement = false)]
    public class Color
    {
        internal const string TableName = @"YDMS.Colors";
        internal const string IdColumnName = @"Id";
        internal const string RedColumnName = @"Red";
        internal const string GreenColumnName = @"Green";
        internal const string BlueColumnName = @"Blue";

        [Column(IdColumnName)]
        public Guid Id { get; set; }

        [Column(RedColumnName)]
        public byte Red { get; set; }

        [Column(GreenColumnName)]
        public byte Green { get; set; }

        [Column(BlueColumnName)]
        public byte Blue { get; set; }
    }
}