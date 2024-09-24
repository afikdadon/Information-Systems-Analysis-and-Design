using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_1
{
    public class Stage
    {
        private string stageName;
        private StageType stageType;
        private DateTime deadline;
        private Status stageStatus;
        private Project project;
        private static int nameCounter = 10;

        
        public Stage(string stageName, StageType stageType, DateTime deadline, Status stageStatus, Project project, bool is_new)
        {
            if (Program.Stages.Count > 0)
            {
                nameCounter = Program.Stages.Max(stage => int.Parse(stage.StageName)) +1;
            }
            else
            {
                nameCounter = 100; 
            }
            this.stageType = stageType;
            this.deadline = deadline;
            this.stageStatus = stageStatus;
            this.project = project;

            if (is_new)
            {
                this.stageName = nameCounter.ToString();
                this.createStage();
                Program.Stages.Add(this);

            }else
                this.stageName = stageName;

        }

        public string StageName { get => stageName; set => stageName = value; }
        public StageType StageType { get => stageType; set => stageType = value; }
        public DateTime Deadline { get => deadline; set => deadline = value; }
        public Status StageStatus { get => stageStatus; set => stageStatus = value; }
        public Project Project { get => project; set => project = value; }

        public void createStage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_add_stage @stageId, @stageType, @deadline, @stageStatus, @projectName";
            c.Parameters.AddWithValue("@stageId", this.stageName);
            c.Parameters.AddWithValue("@stageType", this.stageType.ToString());
            c.Parameters.AddWithValue("@deadline", this.deadline);
            c.Parameters.AddWithValue("@stageStatus", this.stageStatus.ToString());
            c.Parameters.AddWithValue("@projectName", this.project.ProjectName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }

        public void updateStage()
        {
            SqlCommand c = new SqlCommand();
            c.CommandText = "EXECUTE dbo.SP_Update_stage @stageId , @stageType , @deadline, @stageStatus , @projectName ";
            c.Parameters.AddWithValue("@stageId", this.stageName);
            c.Parameters.AddWithValue("@stageType", this.stageType.ToString());
            c.Parameters.AddWithValue("@deadline", this.deadline);
            c.Parameters.AddWithValue("@stageStatus", this.stageStatus.ToString());
            c.Parameters.AddWithValue("@projectName", this.project.ProjectName);
            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(c);
        }
    }
}
