﻿using System;
using System.Collections;

namespace KZONE.Entity
{
	#region SBCSMATERIALHISTORY

	/// <summary>
	/// SBCSMATERIALHISTORY object for NHibernate mapped table 'SBCS_MATERIALHISTORY'.
	/// </summary>
	public class MaterialHistory
	{
		#region Member Variables
		
		protected long _id;
		protected string _nODEID;
		protected string _uNITNO;
		protected DateTime _uPDATETIME=DateTime.Now;
		protected string _mATERIALID;
		protected string _mATERIALCOUNT;
		protected string _mATERIALSTATUS;
		protected string _mATERIALTYPE;
		protected string _oPERATORID;
		protected string _eVENT;
		protected string _oLDMATERIALID;
		protected string _fILENAME;

		#endregion

		#region Constructors

		public MaterialHistory() { }

        public MaterialHistory(string nODEID, string uNITNO, DateTime uPDATETIME, string mATERIALID, string mATERIALCOUNT, string mATERIALSTATUS, string mATERIALTYPE, string oPERATORID, string eVENT, string oLDMATERIALID, string fILENAME)
		{
			this._nODEID = nODEID;
			this._uNITNO = uNITNO;
			this._uPDATETIME = uPDATETIME;
			this._mATERIALID = mATERIALID;
			this._mATERIALCOUNT = mATERIALCOUNT;
			this._mATERIALSTATUS = mATERIALSTATUS;
			this._mATERIALTYPE = mATERIALTYPE;
			this._oPERATORID = oPERATORID;
			this._eVENT = eVENT;
			this._oLDMATERIALID = oLDMATERIALID;
			this._fILENAME = fILENAME;
		}

		#endregion

		#region Public Properties

		public virtual long Id
		{
			get {return _id;}
			set {_id = value;}
		}

		public virtual string NODEID
		{
			get { return _nODEID; }
			set
			{				
				_nODEID = value;
			}
		}

		public virtual string UNITNO
		{
			get { return _uNITNO; }
			set
			{				
				_uNITNO = value;
			}
		}

		public virtual DateTime UPDATETIME
		{
			get { return _uPDATETIME; }
			set { _uPDATETIME = value; }
		}

		public virtual string MATERIALID
		{
			get { return _mATERIALID; }
			set
			{				
				_mATERIALID = value;
			}
		}

		public virtual string MATERIALCOUNT
		{
			get { return _mATERIALCOUNT; }
			set
			{				
				_mATERIALCOUNT = value;
			}
		}

		public virtual string MATERIALSTATUS
		{
			get { return _mATERIALSTATUS; }
			set
			{				
				_mATERIALSTATUS = value;
			}
		}

		public virtual string MATERIALTYPE
		{
			get { return _mATERIALTYPE; }
			set
			{				
				_mATERIALTYPE = value;
			}
		}

		public virtual string OPERATORID
		{
			get { return _oPERATORID; }
			set
			{				
				_oPERATORID = value;
			}
		}

		public virtual string EVENT
		{
			get { return _eVENT; }
			set
			{
                _eVENT = value;
			}
		}

		public virtual string OLDMATERIALID
		{
			get { return _oLDMATERIALID; }
			set
			{				
				_oLDMATERIALID = value;
			}
		}

		public virtual string FILENAME
		{
			get { return _fILENAME; }
			set
			{				
				_fILENAME = value;
			}
		}

		

		#endregion
	}
	#endregion
}