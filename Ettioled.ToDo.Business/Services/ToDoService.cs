using AutoMapper;
using Ettioled.ToDo.Business.Data;
using Ettioled.ToDo.DataAccess;
using Ettioled.ToDo.DataAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ettioled.ToDo.Business.Services
{
    public class ToDoService : IToDoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ToDoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(ToDoData data)
        {
            ToDoRecord item = Mapper.Map<ToDoRecord>(data);
            item.LastUpdatedDate = DateTime.Now;
            item.CreatedDate = DateTime.UtcNow;

            _unitOfWork.ToDo.Add(item);
            _unitOfWork.Complete();
        }

        public IEnumerable<ToDoData> GetUserToDoList(string userId)
        {
            return Mapper.Map<IEnumerable<ToDoData>>(_unitOfWork.ToDo.GetAllByUserId(userId));
        }

        //public void Add(ChannelEventData data)
        //{
        //    ChannelEvent item = Mapper.Map<ChannelEvent>(data);
        //    item.CreatedDate = DateTime.UtcNow;

        //    _unitOfWork.ChannelEvent.Add(item);
        //    _unitOfWork.Complete();
        //}

        public bool Delete(int id, string userId)
        {
            var item = _unitOfWork.ToDo.GetByIdAndUserId(id, userId);
            if (null == item) return false;

            _unitOfWork.ToDo.Remove(item);
            _unitOfWork.Complete();
            return true;
        }

        public void Update(ToDoData todo)
        {
            var item = _unitOfWork.ToDo.GetByIdAndUserId(todo.ToDoId, todo.UserId);

            item.IsDone = todo.IsDone;
            item.Description = todo.Description;
            item.LastUpdatedDate = todo.LastUpdatedDate;

            _unitOfWork.Complete();
        }

        public ToDoData GetById(int id, string userId)
        {
            return Mapper.Map<ToDoData>(_unitOfWork.ToDo.GetByIdAndUserId(id, userId));
        }
    }
}
