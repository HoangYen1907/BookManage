using BookManagement.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookManagement.Common
{
    public class Message
    {
        public Header Header { set; get; }
        public object Data { set; get; }
        public object SubData { set; get; }
        public object SubData2 { set; get; }
        /// <summary>
        /// Trang(page) hiện tại của danh sách trả về.
        /// </summary>
        public int PageIndex { set; get; }
        public int TotalRowData { set; get; }
        public string Description { set; get; }
        public string Description2 { set; get; }
        /// <summary>
        /// Token để kiểm tra tính hợp lệ
        /// </summary>
        public string Token { get; set; }
        public Message()
        {
            this.Header = new Common.Header();
            this.TotalRowData = 0;
        }
        //public Message(decimal msgType)
        //{
        //    this.Header = new Common.Header(msgType);
        //    this.TotalRowData = 0;
        //}
        //public Message(decimal msgType, object msgData, int totalRowData, object msgSubData, string msgToken)
        //{
        //    this.Header = new Common.Header(msgType);
        //    this.Data = msgData;
        //    this.SubData = msgSubData;
        //    this.TotalRowData = totalRowData;
        //    this.Description = Description;
        //    this.Token = msgToken;
        //}
        public string EncodeWMessage(Message msg)
        {
            return JsonConvert.SerializeObject(msg);
        }
        public Message DecodeWMessage(string jsonRequest)
        {
            return JsonConvert.DeserializeObject<Message>(jsonRequest);
        }
    }

    public class Header
    {
        /// <summary>
        /// Tên ứng dụng gửi thông tin
        /// </summary>
        public string ApplicationName { get; set; }
        /// <summary>
        /// Version của ứng dụng gửi thông tin
        /// </summary>
        public string ApplicationVersion { get; set; }
        /// <summary>
        /// Mã của người gửi thông tin: class messageCode
        /// </summary>
        public string SenderCode { set; get; }
        /// <summary>
        /// Tên của người gửi thông tin
        /// </summary>
        public string SenderName { set; get; }
        /// <summary>
        /// Ngày tạo giao dịch
        /// </summary>
        public DateTime SendDate { set; get; }
        /// <summary>
        /// Loại thông điệp gửi: Request[0 - Default, 1 - Lấy thông tin, 2 - Thêm mới, 3 - Edit, 4 - warning, 5 - Delete]
        /// Loại thông điệp trả về: Response messageType[100 - info, 200 - success, 300 - primary, 400 - warning, 500 - danger]
        /// </summary>
        public decimal MsgType { set; get; }
        /// <summary>
        /// Số tham chiếu của giao dịch hỏi - request
        /// </summary>
        public string RequestID { set; get; }
        /// <summary>
        /// Số tham chiếu của giao dịch trả lời - response
        /// </summary>
        public string ResponseID { set; get; }
        //public Header()
        //{
        //    Admin us = System.Web.HttpContext.Current.Session["GET_USER"] as Admin;
        //    this.SenderCode = us.UserName;
        //    this.SenderName = us.FullName;
        //    this.ResponseID = Guid.NewGuid().ToString();
        //    this.SendDate = new DateTime();
        //}

        //public Header(decimal Type)
        //{
        //    USER us = SessionHelper.getSession();
        //    this.ApplicationName = KEYWORD_PAGE.ApplicationName;
        //    this.ApplicationVersion = KEYWORD_PAGE.ApplicationVersion;
        //    this.SenderCode = us.UserName;
        //    this.SenderName = us.FullName;
        //    this.MsgType = Type;
        //    this.ResponseID = Guid.NewGuid().ToString();
        //    this.SendDate = new DateTime();
        //}
    }

    /// <summary>
    /// Các loại thông điệp Request
    /// </summary>
    public class MessageType
    {
        /// <summary>
        /// Response thông tin
        /// </summary>
        public const decimal Informational = 100;
        /// <summary>
        /// Response Thành công.
        /// </summary>
        public const decimal Success = 200;
        /// <summary>
        /// Response Điều hướng
        /// </summary>
        public const decimal Redirection = 300;
        /// <summary>
        /// Response yêu cầu phía client không hợp lệ, bị lỗi
        /// </summary>
        public const decimal ClientError = 400;
        /// <summary>
        /// Response Xử lý server bị lỗi
        /// </summary>
        public const decimal ServerError = 500;
    }
}
