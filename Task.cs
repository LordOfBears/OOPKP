using System;
namespace PlaningTasks
{
    internal class Task
    {
        private string Name;
        private string Description;
        private DateTime DeadLine;
        private int Status;
        public Task(string name, string description, DateTime deadLine, int status)
        {
            this.Name = name;
            this.Description = description;
            this.DeadLine = deadLine;
            this.Status = status;
        }
        public string GetName() { return this.Name; }
        public string GetDescription() { return this.Description; }
        public DateTime GetDeadLine() { return this.DeadLine; }
        public int GetStatus() { return this.Status;}
        public void SetName(string name) { this.Name = name; }
        public void SetDescription(string description) { this.Description = description; }
        public void SetDeadLine(DateTime deadLine) { this.DeadLine = deadLine; }
        public void SetStatus(int status) { this.Status = status; }
    }
}