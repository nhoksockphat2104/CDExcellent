using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CDExcellent.Models
{
    public class CDExcellentDBContext:DbContext
    {
        public CDExcellentDBContext() : base("name=ChuoiKN") { }
        public DbSet<AddArea> AddAreas { get; set; }
        public DbSet<AddArticle> AddArticles { get; set; }
        public DbSet<AddDistributor> AddDistributors { get; set; }
        public DbSet<AddNewUser> AddNewUsers { get; set; }
        public DbSet<AddQuestionnaire> AddQuestionnaires{ get; set; }
        public DbSet<CreateNotification> CreateNotifications { get; set; }
        public DbSet<CreatePlanVisit> CreatePlanVisits { get; set; }
        public DbSet<CreateTask> CreateTasks { get; set; }
        public DbSet<RequestSurvey> RequestSurveys { get; set; }
        public DbSet<TaskDetail> TaskDetails { get; set; }
        public DbSet<VisitPlanDetail> VisitPlanDetails { get; set; }
        public DbSet<Account> Accounts{ get; set; }
    }
}