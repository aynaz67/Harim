using MyFirstApp1399.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstApp1399.Models;

namespace MyFirstApp1399.Services
{
    public class Comment_Srv
    {
        Context entityContext = new Context();
        public void Create_Comment(Comment cmm)
        {
            cmm.CreatedOn = DateTime.Now;
            entityContext.comments.Add(cmm);
            entityContext.SaveChanges();
        }

        public void Update_Comment(Comment cmm)
        {
            Comment cmm_select = entityContext.comments.Find(cmm.Id);
           
            cmm_select.Name = cmm.Name;
            cmm_select.Opinion = cmm.Opinion;
            cmm_select.Email = cmm.Email;
            cmm_select.Post = cmm.Post;
            entityContext.SaveChanges();
        }
        public List<Comment> Read_Comment()
        {
            List<Comment> commentLst = entityContext.comments.ToList();
            return commentLst;
        }

        public void Remove_Comment(int id)
        {
            Comment comm_select = entityContext.comments.Find(id);
            if(comm_select !=null)
            entityContext.comments.Remove(comm_select);
            entityContext.SaveChanges();

        }

    }
}