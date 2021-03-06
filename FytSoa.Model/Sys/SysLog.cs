using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;
using FytSoa.Model.Entity;

namespace FytSoa.Model.Sys
{
    /// <summary>
    /// 系统日志表
    /// </summary>
    [SugarTable("sys_log")]
    public class SysLog : Entity<long>
    {

        /// <summary>
        /// 日志类型  0=登录  1=操作
        /// <summary>
        public int LogType { get; set; } = 0;

        /// <summary>
        /// 操作模块
        /// <summary>
        public string Module { get; set; }

        /// <summary>
        /// 操作类型:例如添加、修改
        /// <summary>
        public string OperateType { get; set; }

        /// <summary>
        /// 提交类型：get/post/delete
        /// <summary>
        public string Method { get; set; }

        /// <summary>
        /// 操作人
        /// <summary>
        public string OperateUser { get; set; }

        /// <summary>
        /// IP
        /// <summary>
        public string IP { get; set; }

        /// <summary>
        /// 操作地址
        /// <summary>
        public string Address { get; set; }

        /// <summary>
        /// 操作状态
        /// <summary>
        public bool Status { get; set; } = true;

        /// <summary>
        /// 详细信息
        /// <summary>
        public string Message { get; set; }

        /// <summary>
        /// 操作时间
        /// <summary>
        public DateTime OperateTime { get; set; } = DateTime.Now;


    }
}