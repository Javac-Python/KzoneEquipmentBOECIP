﻿using System;
using System.Collections;

namespace KZONE.Entity
{
	#region SBRMLINE

	/// <summary>
	/// SBRMLINE object for NHibernate mapped table 'SBRM_LINE'.
	/// </summary>
	public class LineEntityData:EntityData
	{
		#region Member Variables
		
		protected long _id;
		protected string _lINEID;
		protected string _lINENAME;
		protected string _lINETYPE;
		protected string _fABTYPE;
		protected string _sERVERNAME;
		protected string _aTTRIBUTE;
		protected string _jOBDATALINETYPE;
		protected string _nEXTLINEID;
		protected string _cHECKCROSSRECIPE;
		protected string _hISTORYTYPE;
		protected string _oPIFUNCTION;

		#endregion

		#region Constructors

		public LineEntityData() { }

        public LineEntityData(string lINEID, string lINENAME, string lINETYPE, string fABTYPE, string sERVERNAME, string aTTRIBUTE, string jOBDATALINETYPE, string nEXTLINEID, string cHECKCROSSRECIPE, string hISTORYTYPE, string oPIFUNCTION)
		{
			this._lINEID = lINEID;
			this._lINENAME = lINENAME;
			this._lINETYPE = lINETYPE;
			this._fABTYPE = fABTYPE;
			this._sERVERNAME = sERVERNAME;
			this._aTTRIBUTE = aTTRIBUTE;
			this._jOBDATALINETYPE = jOBDATALINETYPE;
			this._nEXTLINEID = nEXTLINEID;
			this._cHECKCROSSRECIPE = cHECKCROSSRECIPE;
			this._hISTORYTYPE = hISTORYTYPE;
			this._oPIFUNCTION = oPIFUNCTION;
		}

		#endregion

		#region Public Properties

		public virtual long Id
		{
			get {return _id;}
			set {_id = value;}
		}

		public virtual string LINEID
		{
			get { return _lINEID; }
			set
			{				
				_lINEID = value;
			}
		}

		public virtual string LINENAME
		{
			get { return _lINENAME; }
			set
			{				
				_lINENAME = value;
			}
		}

		public virtual string LINETYPE
		{
			get { return _lINETYPE; }
			set
			{				
				_lINETYPE = value;
			}
		}

		public virtual string FABTYPE
		{
			get { return _fABTYPE; }
			set
			{				
				_fABTYPE = value;
			}
		}

		public virtual string SERVERNAME
		{
			get { return _sERVERNAME; }
			set
			{				
				_sERVERNAME = value;
			}
		}

		public virtual string ATTRIBUTE
		{
			get { return _aTTRIBUTE; }
			set
			{				
				_aTTRIBUTE = value;
			}
		}

		public virtual string JOBDATALINETYPE
		{
			get { return _jOBDATALINETYPE; }
			set
			{				
				_jOBDATALINETYPE = value;
			}
		}

		public virtual string NEXTLINEID
		{
			get { return _nEXTLINEID; }
			set
			{				
				_nEXTLINEID = value;
			}
		}

		public virtual string CHECKCROSSRECIPE
		{
			get { return _cHECKCROSSRECIPE; }
			set
			{				
				_cHECKCROSSRECIPE = value;
			}
		}

		public virtual string HISTORYTYPE
		{
			get { return _hISTORYTYPE; }
			set
			{				
				_hISTORYTYPE = value;
			}
		}

		public virtual string OPIFUNCTION
		{
			get { return _oPIFUNCTION; }
			set
			{				
				_oPIFUNCTION = value;
			}
		}

		

		#endregion
	}
	#endregion
}