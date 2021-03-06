/**
 * Autogenerated by Thrift Compiler (0.7.0-dev)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 */
using System;
using System.Collections.Generic;
using System.Text;
using Thrift.Protocol;

namespace Thrift.HBase
{
    [Serializable]
    public class TScan : TBase
    {
        public Isset __isset;
        private int _caching;
        private List<byte[]> _columns;
        private byte[] _startRow;
        private byte[] _stopRow;
        private long _timestamp;

        public byte[] StartRow
        {
            get { return this._startRow; }
            set
            {
                this.__isset.startRow = true;
                this._startRow = value;
            }
        }

        public byte[] StopRow
        {
            get { return this._stopRow; }
            set
            {
                this.__isset.stopRow = true;
                this._stopRow = value;
            }
        }

        public long Timestamp
        {
            get { return this._timestamp; }
            set
            {
                this.__isset.timestamp = true;
                this._timestamp = value;
            }
        }

        public List<byte[]> Columns
        {
            get { return this._columns; }
            set
            {
                this.__isset.columns = true;
                this._columns = value;
            }
        }

        public int Caching
        {
            get { return this._caching; }
            set
            {
                this.__isset.caching = true;
                this._caching = value;
            }
        }

        #region TBase Members

        public void Read(TProtocol iprot)
        {
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.String)
                        {
                            this.StartRow = iprot.ReadBinary();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 2:
                        if (field.Type == TType.String)
                        {
                            this.StopRow = iprot.ReadBinary();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 3:
                        if (field.Type == TType.I64)
                        {
                            this.Timestamp = iprot.ReadI64();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 4:
                        if (field.Type == TType.List)
                        {
                            {
                                this.Columns = new List<byte[]>();
                                TList _list9 = iprot.ReadListBegin();
                                for (int _i10 = 0; _i10 < _list9.Count; ++_i10)
                                {
                                    byte[] _elem11 = null;
                                    _elem11 = iprot.ReadBinary();
                                    this.Columns.Add(_elem11);
                                }
                                iprot.ReadListEnd();
                            }
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    case 5:
                        if (field.Type == TType.I32)
                        {
                            this.Caching = iprot.ReadI32();
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("TScan");
            oprot.WriteStructBegin(struc);
            var field = new TField();
            if (this.StartRow != null && this.__isset.startRow)
            {
                field.Name = "startRow";
                field.Type = TType.String;
                field.ID = 1;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.StartRow);
                oprot.WriteFieldEnd();
            }
            if (this.StopRow != null && this.__isset.stopRow)
            {
                field.Name = "stopRow";
                field.Type = TType.String;
                field.ID = 2;
                oprot.WriteFieldBegin(field);
                oprot.WriteBinary(this.StopRow);
                oprot.WriteFieldEnd();
            }
            if (this.__isset.timestamp)
            {
                field.Name = "timestamp";
                field.Type = TType.I64;
                field.ID = 3;
                oprot.WriteFieldBegin(field);
                oprot.WriteI64(this.Timestamp);
                oprot.WriteFieldEnd();
            }
            if (this.Columns != null && this.__isset.columns)
            {
                field.Name = "columns";
                field.Type = TType.List;
                field.ID = 4;
                oprot.WriteFieldBegin(field);
                {
                    oprot.WriteListBegin(new TList(TType.String, this.Columns.Count));
                    foreach (var _iter12 in this.Columns)
                    {
                        oprot.WriteBinary(_iter12);
                    }
                    oprot.WriteListEnd();
                }
                oprot.WriteFieldEnd();
            }
            if (this.__isset.caching)
            {
                field.Name = "caching";
                field.Type = TType.I32;
                field.ID = 5;
                oprot.WriteFieldBegin(field);
                oprot.WriteI32(this.Caching);
                oprot.WriteFieldEnd();
            }
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        #endregion

        public override string ToString()
        {
            var sb = new StringBuilder("TScan(");
            sb.Append("StartRow: ");
            sb.Append(this.StartRow);
            sb.Append(",StopRow: ");
            sb.Append(this.StopRow);
            sb.Append(",Timestamp: ");
            sb.Append(this.Timestamp);
            sb.Append(",Columns: ");
            sb.Append(this.Columns);
            sb.Append(",Caching: ");
            sb.Append(this.Caching);
            sb.Append(")");
            return sb.ToString();
        }

        #region Nested type: Isset

        [Serializable]
        public struct Isset
        {
            public bool caching;
            public bool columns;
            public bool startRow;
            public bool stopRow;
            public bool timestamp;
        }

        #endregion
    }
}