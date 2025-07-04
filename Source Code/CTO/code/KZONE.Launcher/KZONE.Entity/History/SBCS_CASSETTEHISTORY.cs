﻿using System;
using System.Collections;

namespace KZONE.Entity
{
    #region SBCSCASSETTEHISTORY

    /// <summary>
    /// SBCSCASSETTEHISTORY object for NHibernate mapped table 'SBCS_CASSETTEHISTORY'.
    /// </summary>
    public class CassetteHistory : EntityData
    {
        #region Member Variables

        protected long _id;
        protected DateTime _uPDATETIME=DateTime.Now;
        protected string _cASSETTEID;
        protected int _cASSETTESEQNO;
        protected string _cASSETTESTATUS;
        protected string _nODEID;
        protected int _jOBCOUNT;
        protected string _pORTID;
        protected string _jOBEXISTENCE;
        protected string _cASSETTECONTROLCOMMAND;
        protected string _cOMMANDRETURNCODE;
        protected string _oPERATORID;
        protected string _cOMMPLETEDCASSETTEDATA;
        protected string _lOADINGCASSETTETYPE;
        protected int _qTIMEFLAG;
        protected int _pARTIALFULLFLAG;
        protected DateTime _lOADTIME=DateTime.Now;
        protected DateTime _pROCESSSTATTIME = DateTime.Now;
        protected DateTime _pROCESSENDTIME = DateTime.Now;

        #endregion

        #region Constructors

        public CassetteHistory() { }

        public CassetteHistory(DateTime uPDATETIME, string cASSETTEID, int cASSETTESEQNO, string cASSETTESTATUS, string nODEID, int jOBCOUNT, string pORTID, string jOBEXISTENCE, string cASSETTECONTROLCOMMAND, string cOMMANDRETURNCODE, string oPERATORID, string cOMMPLETEDCASSETTEDATA, string lOADINGCASSETTETYPE, int qTIMEFLAG, int pARTIALFULLFLAG, DateTime lOADTIME, DateTime pROCESSSTATTIME, DateTime pROCESSENDTIME)
        {
            this._uPDATETIME = uPDATETIME;
            this._cASSETTEID = cASSETTEID;
            this._cASSETTESEQNO = cASSETTESEQNO;
            this._cASSETTESTATUS = cASSETTESTATUS;
            this._nODEID = nODEID;
            this._jOBCOUNT = jOBCOUNT;
            this._pORTID = pORTID;
            this._jOBEXISTENCE = jOBEXISTENCE;
            this._cASSETTECONTROLCOMMAND = cASSETTECONTROLCOMMAND;
            this._cOMMANDRETURNCODE = cOMMANDRETURNCODE;
            this._oPERATORID = oPERATORID;
            this._cOMMPLETEDCASSETTEDATA = cOMMPLETEDCASSETTEDATA;
            this._lOADINGCASSETTETYPE = lOADINGCASSETTETYPE;
            this._qTIMEFLAG = qTIMEFLAG;
            this._pARTIALFULLFLAG = pARTIALFULLFLAG;
            this._lOADTIME = lOADTIME;
            this._pROCESSSTATTIME = pROCESSSTATTIME;
            this._pROCESSENDTIME = pROCESSENDTIME;
        }

        #endregion

        #region Public Properties

        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public virtual DateTime UPDATETIME
        {
            get { return _uPDATETIME; }
            set { _uPDATETIME = value; }
        }

        public virtual string CASSETTEID
        {
            get { return _cASSETTEID; }
            set
            {
                _cASSETTEID = value;
            }
        }

        public virtual int CASSETTESEQNO
        {
            get { return _cASSETTESEQNO; }
            set { _cASSETTESEQNO = value; }
        }

        public virtual string CASSETTESTATUS
        {
            get { return _cASSETTESTATUS; }
            set
            {
                _cASSETTESTATUS = value;
            }
        }

        public virtual string NODEID
        {
            get { return _nODEID; }
            set
            {
                _nODEID = value;
            }
        }

        public virtual int JOBCOUNT
        {
            get { return _jOBCOUNT; }
            set { _jOBCOUNT = value; }
        }

        public virtual string PORTID
        {
            get { return _pORTID; }
            set
            {
                _pORTID = value;
            }
        }

        public virtual string JOBEXISTENCE
        {
            get { return _jOBEXISTENCE; }
            set
            {
                _jOBEXISTENCE = value;
            }
        }

        public virtual string CASSETTECONTROLCOMMAND
        {
            get { return _cASSETTECONTROLCOMMAND; }
            set
            {
                _cASSETTECONTROLCOMMAND = value;
            }
        }

        public virtual string COMMANDRETURNCODE
        {
            get { return _cOMMANDRETURNCODE; }
            set
            {
                _cOMMANDRETURNCODE = value;
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

        public virtual string COMMPLETEDCASSETTEDATA
        {
            get { return _cOMMPLETEDCASSETTEDATA; }
            set
            {
                _cOMMPLETEDCASSETTEDATA = value;
            }
        }

        public virtual string LOADINGCASSETTETYPE
        {
            get { return _lOADINGCASSETTETYPE; }
            set
            {
                _lOADINGCASSETTETYPE = value;
            }
        }

        public virtual int QTIMEFLAG
        {
            get { return _qTIMEFLAG; }
            set { _qTIMEFLAG = value; }
        }

        public virtual int PARTIALFULLFLAG
        {
            get { return _pARTIALFULLFLAG; }
            set { _pARTIALFULLFLAG = value; }
        }

        public virtual DateTime LOADTIME
        {
            get { return _lOADTIME; }
            set { _lOADTIME = value; }
        }

        public virtual DateTime PROCESSSTATTIME
        {
            get { return _pROCESSSTATTIME; }
            set { _pROCESSSTATTIME = value; }
        }

        public virtual DateTime PROCESSENDTIME
        {
            get { return _pROCESSENDTIME; }
            set { _pROCESSENDTIME = value; }
        }



        #endregion
    }
    #endregion
}

//using System;
//using System.Collections;

//namespace KZONE.Entity
//{
//    #region SBCSCASSETTEHISTORY

//    /// <summary>
//    /// SBCSCASSETTEHISTORY object for NHibernate mapped table 'SBCS_CASSETTEHISTORY'.
//    /// </summary>
//    public class CassetteHistory : EntityData
//    {
//        #region Member Variables
		
//        protected long _id;
//        protected DateTime _uPDATETIME;
//        protected string _cASSETTEID;
//        protected int _cASSETTESEQNO;
//        protected string _cASSETTESTATUS;
//        protected string _nODEID;
//        protected int _jOBCOUNT;
//        protected string _pORTID;
//        protected string _jOBEXISTENCE;
//        protected string _cASSETTECOMMAND;
//        protected string _cOMMANDRETURNCODE;
//        protected string _oPERATORID;
//        protected string _cOMPLETEDCASSETTEDATA;
//        protected string _cASSETTETYPE;
//        protected int _qTIMEFLAG;
//        protected int _pARTIALFULLFLAG;
//        protected DateTime _lOADTIME;
//        protected DateTime _pROCESSSTARTTIME;
//        protected DateTime _pROCESSENDTIME;
//        protected string _tRANSACTIONID;

//        #endregion

//        #region Constructors

//        public CassetteHistory() { }

//        public CassetteHistory(DateTime uPDATETIME, string cASSETTEID, int cASSETTESEQNO, string cASSETTESTATUS, string nODEID, int jOBCOUNT, string pORTID, string jOBEXISTENCE, string cASSETTECOMMAND, string cOMMANDRETURNCODE, string oPERATORID, string cOMPLETEDCASSETTEDATA, string cASSETTETYPE, int qTIMEFLAG, int pARTIALFULLFLAG, DateTime lOADTIME, DateTime pROCESSSTARTTIME, DateTime pROCESSENDTIME, string tRANSACTIONID)
//        {
//            this._uPDATETIME = uPDATETIME;
//            this._cASSETTEID = cASSETTEID;
//            this._cASSETTESEQNO = cASSETTESEQNO;
//            this._cASSETTESTATUS = cASSETTESTATUS;
//            this._nODEID = nODEID;
//            this._jOBCOUNT = jOBCOUNT;
//            this._pORTID = pORTID;
//            this._jOBEXISTENCE = jOBEXISTENCE;
//            this._cASSETTECOMMAND = cASSETTECOMMAND;
//            this._cOMMANDRETURNCODE = cOMMANDRETURNCODE;
//            this._oPERATORID = oPERATORID;
//            this._cOMPLETEDCASSETTEDATA = cOMPLETEDCASSETTEDATA;
//            this._cASSETTETYPE = cASSETTETYPE;
//            this._qTIMEFLAG = qTIMEFLAG;
//            this._pARTIALFULLFLAG = pARTIALFULLFLAG;
//            this._lOADTIME = lOADTIME;
//            this._pROCESSSTARTTIME = pROCESSSTARTTIME;
//            this._pROCESSENDTIME = pROCESSENDTIME;
//            this._tRANSACTIONID = tRANSACTIONID;
//        }

//        #endregion

//        #region Public Properties

//        public virtual long Id
//        {
//            get {return _id;}
//            set {_id = value;}
//        }

//        public virtual DateTime UPDATETIME
//        {
//            get { return _uPDATETIME; }
//            set { _uPDATETIME = value; }
//        }

//        public virtual string CASSETTEID
//        {
//            get { return _cASSETTEID; }
//            set
//            {				
//                _cASSETTEID = value;
//            }
//        }

//        public virtual int CASSETTESEQNO
//        {
//            get { return _cASSETTESEQNO; }
//            set { _cASSETTESEQNO = value; }
//        }

//        public virtual string CASSETTESTATUS
//        {
//            get { return _cASSETTESTATUS; }
//            set
//            {				
//                _cASSETTESTATUS = value;
//            }
//        }

//        public virtual string NODEID
//        {
//            get { return _nODEID; }
//            set
//            {				
//                _nODEID = value;
//            }
//        }

//        public virtual int JOBCOUNT
//        {
//            get { return _jOBCOUNT; }
//            set { _jOBCOUNT = value; }
//        }

//        public virtual string PORTID
//        {
//            get { return _pORTID; }
//            set
//            {				
//                _pORTID = value;
//            }
//        }

//        public virtual string JOBEXISTENCE
//        {
//            get { return _jOBEXISTENCE; }
//            set
//            {				
//                _jOBEXISTENCE = value;
//            }
//        }

//        public virtual string CASSETTECOMMAND
//        {
//            get { return _cASSETTECOMMAND; }
//            set
//            {				
//                _cASSETTECOMMAND = value;
//            }
//        }

//        public virtual string COMMANDRETURNCODE
//        {
//            get { return _cOMMANDRETURNCODE; }
//            set
//            {				
//                _cOMMANDRETURNCODE = value;
//            }
//        }

//        public virtual string OPERATORID
//        {
//            get { return _oPERATORID; }
//            set
//            {				
//                _oPERATORID = value;
//            }
//        }

//        public virtual string COMPLETEDCASSETTEDATA
//        {
//            get { return _cOMPLETEDCASSETTEDATA; }
//            set
//            {				
//                _cOMPLETEDCASSETTEDATA = value;
//            }
//        }

//        public virtual string CASSETTETYPE
//        {
//            get { return _cASSETTETYPE; }
//            set
//            {				
//                _cASSETTETYPE = value;
//            }
//        }

//        public virtual int QTIMEFLAG
//        {
//            get { return _qTIMEFLAG; }
//            set { _qTIMEFLAG = value; }
//        }

//        public virtual int PARTIALFULLFLAG
//        {
//            get { return _pARTIALFULLFLAG; }
//            set { _pARTIALFULLFLAG = value; }
//        }

//        public virtual DateTime LOADTIME
//        {
//            get { return _lOADTIME; }
//            set { _lOADTIME = value; }
//        }

//        public virtual DateTime PROCESSSTARTTIME
//        {
//            get { return _pROCESSSTARTTIME; }
//            set { _pROCESSSTARTTIME = value; }
//        }

//        public virtual DateTime PROCESSENDTIME
//        {
//            get { return _pROCESSENDTIME; }
//            set { _pROCESSENDTIME = value; }
//        }

//        public virtual string TRANSACTIONID
//        {
//            get { return _tRANSACTIONID; }
//            set { _tRANSACTIONID = value; }
//        }

//        #endregion
//    }
//    #endregion
//}