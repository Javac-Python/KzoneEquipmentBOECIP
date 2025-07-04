using System;

namespace KZONE.PLCAgent.PLC
{
	/// <summary>
	/// plcadapter errorcode constant define
	/// </summary>
	internal class AdapterErrorConst
	{
		public const int ADAPTER_BEGININIT_NOT_X86_PLATFORM_ERR = 10000;

		public const int ADAPTER_BEGININIT_ALREADY_INITED_ERR = 10001;

		public const int ADAPTER_BEGININIT_IS_INITIALIZING_ERR = 10002;

		public const int ADAPTER_BEGININIT_EXCEPTION_ERR = 10004;

		public const int ADAPTER_BEGININIT_STARTWORK_EXCEPTION_ERR = 10005;

		public const int ADAPTER_BEGININIT_FAIL_TO_CREATE_ADAPTER_ERR = 10006;

		public const int ADAPTER_BEGININIT_FAIL_TO_INIT_PLC_ERR = 10007;

		public const int ADAPTER_BEGININIT_TIMEOUT_ERR = 10008;

		public const int ADAPTER_ENDINIT_EXCEPTION_ERR = 10051;

		public const int ADAPTER_OPEN_NOT_INITED_ERR = 10101;

		public const int ADAPTER_CLOSE_NOT_INITED_ERR = 10201;

		public const int ADAPTER_CLOSE_NOT_OPENED_ERR = 10202;

		public const int ADAPTER_CLOSE_FAIL_TO_CLOSE_PLC_ERR = 10203;

		public const int ADAPTER_BEGINREAD_NOT_INITED_ERR = 10301;

		public const int ADAPTER_BEGINREAD_NOT_OPENED_ERR = 10302;

		public const int ADAPTER_BEGINREAD_NOT_CONNECTED_ERR = 10303;

		public const int ADAPTER_BEGINREAD_FAIL_TO_READ_PLC_ERR = 10304;

		public const int ADAPTER_BEGINREAD_EXCEPTION_ERR = 10305;

		public const int ADAPTER_BEGINREAD_DEVICETYPE_ERR = 10306;

		public const int ADAPTER_BEGINREAD_BUFSIZE_ERR = 10307;

		public const int ADAPTER_BEGINREAD_DEVICENO_ERR = 10308;

		public const int ADAPTER_BEGINREAD_TIMEOUT_ERR = 10309;

		public const int ADAPTER_BEGINREAD_NO_OPS_FOUND_ERR = 10310;

		public const int ADAPTER_ENDREAD_EXCEPTION_ERR = 10351;

		public const int ADAPTER_BEGINWRITE_NOT_INITED_ERR = 10401;

		public const int ADAPTER_BEGINWRITE_NOT_OPENED_ERR = 10402;

		public const int ADAPTER_BEGINWRITE_NOT_CONNECTED_ERR = 10403;

		public const int ADAPTER_BEGINWRITE_FAIL_TO_WRITE_PLC_ERR = 10404;

		public const int ADAPTER_BEGINWRITE_EXCEPTION_ERR = 10405;

		public const int ADAPTER_BEGINWRITE_DEVICETYPE_ERR = 10406;

		public const int ADAPTER_BEGINWRITE_BUFSIZE_ERR = 10407;

		public const int ADAPTER_BEGINWRITE_DEVICENO_ERR = 10408;

		public const int ADAPTER_BEGINWRITE_DEVICENO_16_ERR = 10409;

		public const int ADAPTER_BEGINWRITE_POINTS_16_ERR = 10410;

		public const int ADAPTER_BEGINWRITE_TIMEOUT_ERR = 10411;

		public const int ADAPTER_BEGINWRITE_NO_OPS_FOUND_ERR = 10412;

		public const int ADAPTER_ENDWRITE_EXCEPTION_ERR = 10452;

		public const int ADAPTER_DOWORK_HANDLEREADREQ_EXCEPTION_ERR = 10701;

		public const int ADAPTER_DOWORK_HANDLEWRITEREQ_EXCEPTION_ERR = 10702;

		public const int ADAPTER_DOWORK_HANDLEREADDELAY_EXCEPTION_ERR = 10703;

		public const int ADAPTER_DOWORK_HANDLEWRITEDELAY_EXCEPTION_ERR = 10704;

		public const int ADAPTER_DOWORK_HANDLEREADREQ_REQ_NULL_ERR = 10705;

		public const int ADAPTER_DOWORK_HANDLEREADDELAY_REQ_NULL_ERR = 10706;

		public const int ADAPTER_DOWORK_HANDLEWRITEREQ_REQ_NULL_ERR = 10707;

		public const int ADAPTER_DOWORK_HANDLEWRITEDELAY_REQ_NULL_ERR = 10708;

		public const int ADAPTER_DOWORK_HANDLEWRITEREQ_TRYADD_DICT_ERR = 10709;

		public const int ADAPTER_DOWORK_HANDLEREADREQ_TRYADD_DICT_ERR = 10710;

		public const int ADAPTER_DOWORK_BLOCKREAD_ERR = 10750;

		public const int ADAPTER_DOWORK_RANDREAD_ERR = 10751;

		public const int ADAPTER_DOWORK_BLOCKWRITE_ERR = 10752;

		public const int ADAPTER_DOWORK_RANDWRITE_ERR = 10753;
	}
}
