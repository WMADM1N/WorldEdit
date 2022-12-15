using Auxiliary;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldEdit.Entities
{
    [BsonIgnoreExtraElements]
    public class WorldEditUser : BsonModel
    {

        private int _tshockId;
        public int TShockId
        {
            get
                => _tshockId;
            set
            {
                _ = this.SaveAsync(x => x.TShockId, value);
                _tshockId = value;
            }
        }

        private int _undoAmount;
        public int UndoLevel
        {
            get
                => _undoAmount;
            set
            {
                _ = this.SaveAsync(x => x.UndoLevel, value);
                _undoAmount = value;
            }
        }

        private int _redoAmount;
        public int RedoLevel
        {
            get
                => _redoAmount;
            set
            {
                _ = this.SaveAsync(x => x.RedoLevel, value);
                _redoAmount = value;
            }
        }
    }
}
