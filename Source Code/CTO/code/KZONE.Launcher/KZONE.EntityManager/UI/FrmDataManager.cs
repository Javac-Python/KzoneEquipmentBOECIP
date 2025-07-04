﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Spring.Context;
using Spring.Objects.Factory;
using KZONE.Entity;
using KZONE.Log;

namespace KZONE.EntityManager.UI
{
    public enum REMOVERECOVERY
    {
        REMOVE,
        RECOVERY
    }
    public partial class FrmDataManager : Form//, IApplicationContextAware
    {
        private IApplicationContext _applicationContext;
        //private ObjectManager _managerObject = null;
        private IDictionary<string,DataTable> dataSet=new Dictionary<string ,DataTable>();
        public IApplicationContext ApplicationContext
        {
            get { return _applicationContext; }
            set { _applicationContext = value; }
        }

        public FrmDataManager()
        {
            InitializeComponent();
        }

        public void Init()
        {
        }

        private void FrmDataManager_Load(object sender, EventArgs e)
        {
            try
            {
                PropertyInfo[] propertyInfos = typeof(ObjectManager).GetProperties(BindingFlags.Static | BindingFlags.Public);
                
                foreach(PropertyInfo info in propertyInfos)
                {
                  
                    object obj = info.GetValue(null, null);//取得instance
                    if (obj != null)
                    {
                        
                        Type type = obj.GetType();
                        if (!type.IsAbstract && !type.IsInterface && typeof(IDataSource).IsAssignableFrom(type))
                        {
                            TreeNode tn = _treTreeView.Nodes.Add(info.Name);
                            IDataSource ds = obj as IDataSource;
                            tn.Tag = obj;
                            IList<string> entityNames = ds.GetEntityNames();
                            foreach (string name in entityNames)
                            {
                                TreeNode node =tn.Nodes.Add(name);
                                node.Tag = name;
                            }

                        }
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }
        }

        private void _treTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (_treTreeView.SelectedNode != null && _treTreeView.SelectedNode.Tag is string)
            {
                _dgvDataGird.DataSource = null;//此行是必要的, 因DataGridView的欄位問題

                DataTable dt = ((IDataSource)_treTreeView.SelectedNode.Parent.Tag).GetDataTable(_treTreeView.SelectedNode.Tag.ToString());
                if (dt != null)
                {
                    _dgvDataGird.DataSource = dt;
                    return;
                }
            }
            
             _dgvDataGird.DataSource = null;
            
        }

        private void _dgvDataGird_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && _treTreeView.SelectedNode != null )
            {
                deleteToolStripMenuItem1.Enabled = true;

                if (_treTreeView.SelectedNode.Level>0 && _treTreeView.SelectedNode.Tag.ToString() == "JobManager" && _dgvDataGird.SelectedRows.Count>0)
                {
                    contextMenuStrip1.Show(_dgvDataGird, e.X, e.Y);
                }
                else if (_treTreeView.SelectedNode.Level>0 && _treTreeView.SelectedNode.Text == "CassetteManager" && _dgvDataGird.SelectedRows.Count > 0)
                {
                    contextMenuStrip2.Show(_dgvDataGird, e.X, e.Y);
                }
                else if (_treTreeView.SelectedNode.Level>0 && _treTreeView.SelectedNode.Text == "RobotJobManager" && _dgvDataGird.SelectedRows.Count > 0)
                {
                    contextMenuStrip2.Show(_dgvDataGird, e.X, e.Y);
                }
                else if (_treTreeView.SelectedNode.Level > 0 && _treTreeView.SelectedNode.Text == "PlanManager" && _dgvDataGird.SelectedRows.Count > 0)
                {
                    contextMenuStrip2.Show(_dgvDataGird, e.X, e.Y);
                }
                else if (_treTreeView.SelectedNode.Level > 0 && _treTreeView.SelectedNode.Text == "BatchManager" && _dgvDataGird.SelectedRows.Count > 0)
                {
                    contextMenuStrip2.Show(_dgvDataGird, e.X, e.Y);
                } else if (_treTreeView.SelectedNode.Level > 0 && _treTreeView.SelectedNode.Text == "PortManager" && _dgvDataGird.SelectedRows.Count > 0) {

                    deleteToolStripMenuItem1.Enabled = false;
                    contextMenuStrip2.Show(_dgvDataGird, e.X, e.Y);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_dgvDataGird.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you wan't Delete Jobs", "Delete Job", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    return;
                }

                List<Job> jobs=new List<Job>();
                foreach (DataGridViewRow row in _dgvDataGird.SelectedRows)
                {
                    string cstSeqNo=row.Cells["CassetteSequenceNo"].Value.ToString();
                    string jobSeqNo=row.Cells["JobSequenceNo"].Value.ToString();
                    
                    Job job= ObjectManager.JobManager.GetJob(cstSeqNo,jobSeqNo);
                    if(job!=null)
                    {
                        jobs.Add(job);
                    }
                    
                }

                if (jobs.Count > 0)
                {
                    ObjectManager.JobManager.DeleteJobs(jobs);

                    _treTreeView_AfterSelect(null, null);
                }
            }
        }

        private void _dgvDataGird_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ObjectMonitor monitor = new ObjectMonitor();
                object obj = null;
                string objectName = "";
                if (_dgvDataGird.SelectedRows.Count > 0)
                {
                    if (_treTreeView.SelectedNode.Text == "EquipmentManager")
                    {
                        string nodeID = _dgvDataGird.SelectedRows[0].Cells["NodeID"].Value.ToString();

                        Equipment eq = ObjectManager.EquipmentManager.GetEquipmentByID(nodeID);
                        if (eq != null)
                        {
                            obj = eq;
                            objectName = nodeID;
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "JobManager")
                    {
                        string cstSeqNo = _dgvDataGird.SelectedRows[0].Cells["CassetteSequenceNo"].Value.ToString();
                        string jobSeqNo = _dgvDataGird.SelectedRows[0].Cells["JobSequenceNo"].Value.ToString();

                        Job job = ObjectManager.JobManager.GetJob(cstSeqNo, jobSeqNo);
                        if (job != null)
                        {
                            obj = job;
                            objectName = cstSeqNo + "_" + jobSeqNo;
                        }

                    }
                    else if (_treTreeView.SelectedNode.Text == "LineManager")
                    {
                        string lineName = _dgvDataGird.SelectedRows[0].Cells["LineID"].Value.ToString();
                        Line line = ObjectManager.LineManager.GetLine(lineName);
                        if (line != null)
                        {
                            obj = line;
                            objectName = lineName;
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "PortManager")
                    {
                        string portId = _dgvDataGird.SelectedRows[0].Cells["PortID"].Value.ToString();
                        Port port = ObjectManager.PortManager.GetPort(portId);
                        if (port != null)
                        {
                            obj = port;
                            objectName = portId;
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "CassetteManager")
                    {
                        string cstId = _dgvDataGird.SelectedRows[0].Cells["CassetteID"].Value.ToString();
                        Cassette cst = ObjectManager.CassetteManager.GetCassette(cstId);
                        if (cst != null)
                        {
                            obj = cst;
                            objectName = cstId;
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "UnitManager")
                    {
                        string unitId = _dgvDataGird.SelectedRows[0].Cells["UnitID"].Value.ToString();
                        Unit unit = ObjectManager.UnitManager.GetUnit(unitId);
                        if (unit != null)
                        {
                            obj = unit;
                            objectName = unitId;
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "MaterialManager")
                    {
                        string materialId = _dgvDataGird.SelectedRows[0].Cells["MaterialID"].Value.ToString();
                        string nodeNo = _dgvDataGird.SelectedRows[0].Cells["NodeNo"].Value.ToString();
                        MaterialEntity material = ObjectManager.MaterialManager.GetMaterialByID(nodeNo, materialId);
                        if (material != null)
                        {
                            obj = material;
                            objectName = nodeNo + "_" + materialId;
                        }
                    } else if (_treTreeView.SelectedNode.Text == "BatchManager") {
                        string eqpNo = _dgvDataGird.SelectedRows[0].Cells["StartEquipmentNo"].Value.ToString();
                        string batchId = _dgvDataGird.SelectedRows[0].Cells["BatchId"].Value.ToString();
                        BatchEntityFile batch = ObjectManager.SamplingRuleManager.GetBatch(eqpNo, batchId);
                        if (batch != null) {
                            obj = batch;
                            objectName = eqpNo + "_" + batchId;
                        }
                    } else if (_treTreeView.SelectedNode.Text == "GroupNoManager") {
                        int groupNo = Convert.ToInt32(_dgvDataGird.SelectedRows[0].Cells["Value"].Value);
                        GroupNo group = ObjectManager.GroupNoManager.GetGroupNo(groupNo);
                        if (group != null) {
                            obj = group;
                            objectName = group.Value.ToString();
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "PlanManager")
                    {
                        string planId = _dgvDataGird.SelectedRows[0].Cells["PLAN_NAME"].Value.ToString();
                        Plan plan = ObjectManager.PlanManager.GetPlan(planId);
                        if (plan != null)
                        {
                            obj = plan;
                            objectName = planId;
                        }
                    }
                   
    
                    if (obj != null)
                    {
                        monitor.ObjectName = objectName;
                        monitor.SelectObject = obj;
                        monitor.ShowDialog();
                    }

                }
            }
            catch (System.Exception ex)
            {
                NLogManager.Logger.LogErrorWrite("Service", this.GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);
            }
            

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemoveRecoveryJob removeRecoveryJob = new FrmRemoveRecoveryJob(REMOVERECOVERY.REMOVE);
            string equipmentNo="";
            string cstSeq="";
            string slotNo = "";
            if (removeRecoveryJob.ShowDialog() == DialogResult.OK)
            {
                equipmentNo = removeRecoveryJob.EquipmentNo;
                cstSeq = removeRecoveryJob.CstSeq;
                slotNo = removeRecoveryJob.SlotNo;
                ObjectManager.JobManager.RemoveJobByUI(equipmentNo, cstSeq, slotNo);
                //string msg=ObjectManager.JobManager.RemoveJobByUI(equipmentNo, cstSeq, slotNo);
            }
            

        }
      
        private void recoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRemoveRecoveryJob removeRecoveryJob = new FrmRemoveRecoveryJob(REMOVERECOVERY.RECOVERY);
            string equipmentNo = "";
            string cstSeq = "";
            string slotNo = "";
            if (removeRecoveryJob.ShowDialog() == DialogResult.OK)
            {
                equipmentNo = removeRecoveryJob.EquipmentNo;
                cstSeq = removeRecoveryJob.CstSeq;
                slotNo = removeRecoveryJob.SlotNo;
                ObjectManager.JobManager.RecoveryJobByUI(equipmentNo, cstSeq, slotNo);
                //string msg=ObjectManager.JobManager.RecoveryJobByUI(equipmentNo, cstSeq, slotNo);
            }
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _treTreeView_AfterSelect(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dgvDataGird.SelectedRows.Count == 1)
                {
                    if (_treTreeView.SelectedNode.Text == "JobManager")
                    {
                        string cstSeqNo = _dgvDataGird.SelectedRows[0].Cells["CassetteSequenceNo"].Value.ToString();
                        string jobSeqNo = _dgvDataGird.SelectedRows[0].Cells["JobSequenceNo"].Value.ToString();

                        Job job = ObjectManager.JobManager.GetJob(cstSeqNo, jobSeqNo);
                        if (job != null)
                        {
                            FrmObjectEdit edit = new FrmObjectEdit();
                            edit.ObjectName = job.JobKey;
                            edit.SelectObject = job;
                            edit.Show();
                        }

                    }
                    else if (_treTreeView.SelectedNode.Text == "JobManager")
                    { 
                    
                    }

                }
            }
            catch (System.Exception ex)
            {
                NLogManager.Logger.LogErrorWrite("Service", this.GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);

            }
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dgvDataGird.SelectedRows.Count == 1)
                {
                    if (_treTreeView.SelectedNode.Text == "CassetteManager")
                    {
                        string cassetteID = _dgvDataGird.SelectedRows[0].Cells["CassetteID"].Value.ToString();


                        Cassette cassette = ObjectManager.CassetteManager.GetCassette(cassetteID);
                        if (cassette != null)
                        {
                            FrmObjectEdit edit = new FrmObjectEdit();
                            edit.ObjectName = cassette.CassetteID;
                            edit.SelectObject = cassette;
                            edit.Show();
                        }

                    }
                    else if (_treTreeView.SelectedNode.Text == "BatchManager")
                    {
                        string batchID = _dgvDataGird.SelectedRows[0].Cells["BATCHID"].Value.ToString();
                        BatchEntityFile batch = ObjectManager.SamplingRuleManager.GetBatchByID(batchID);
                        if (batch != null)
                        {
                            FrmObjectEdit edit = new FrmObjectEdit();
                            edit.ObjectName = batch.BatchId;
                            edit.SelectObject = batch;
                            edit.Show();
                        }
                    } else if (_treTreeView.SelectedNode.Text == "PortManager") {
                        string portID = _dgvDataGird.SelectedRows[0].Cells["PORTID"].Value.ToString();
                        Port port = ObjectManager.PortManager.GetPort(portID);
                        if (port != null) {
                            FrmObjectEdit edit = new FrmObjectEdit();
                            edit.ObjectName = port.Data.PORTID;
                            edit.SelectObject = port.File;
                            edit.Show();
                        }
                    }
                    //else if (_treTreeView.SelectedNode.Text == "RobotJobManager")
                    //{
                    //    string cstSeqNo = _dgvDataGird.SelectedRows[0].Cells["CstSeqNo"].Value.ToString();
                    //    string jobSeqNo = _dgvDataGird.SelectedRows[0].Cells["JobSeqNo"].Value.ToString();

                    //    RobotJob job = ObjectManager.RobotJobManager.GetRobotJob(cstSeqNo, jobSeqNo);
                    //    if (job != null)
                    //    {
                    //        FrmObjectEdit edit = new FrmObjectEdit();
                    //        edit.ObjectName = job.JobKey;
                    //        edit.SelectObject = job;
                    //        edit.Show();
                    //    }

                    //}
                }
            }
            catch (System.Exception ex)
            {
                NLogManager.Logger.LogErrorWrite("Service", this.GetType().Name, MethodBase.GetCurrentMethod().Name + "()", ex);

            }
           
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_dgvDataGird.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Do you wan't Delete Object", "Delete Object", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    return;
                }
                if (_dgvDataGird.SelectedRows.Count == 1)
                {
                    if (_treTreeView.SelectedNode.Text == "CassetteManager")
                    {
                        List<string> cstIds=new List<string>();
                        foreach (DataGridViewRow row in _dgvDataGird.SelectedRows)
                        {
                            string cstSeqNo=row.Cells["CassetteSequenceNo"].Value.ToString();
                            ObjectManager.CassetteManager.DeleteCassette(cstSeqNo);
                        }
                    }
                    else if (_treTreeView.SelectedNode.Text == "PlanManager")
                    {
                        
                        foreach (DataGridViewRow row in _dgvDataGird.SelectedRows)
                        {
                            string planId = row.Cells["PLAN_NAME"].Value.ToString();
                            ObjectManager.PlanManager.DeletePlan(planId);
                        }
                    }
                }

                _treTreeView_AfterSelect(null, null);
                
               
                    
                
            }
        }
    }
}
