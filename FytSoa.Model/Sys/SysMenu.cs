using System;
using System.Collections.Generic;
using System.Text;
using SqlSugar;
using Newtonsoft.Json;
using FytSoa.Model.Entity;

namespace FytSoa.Model.Sys
{
    /// <summary>
    /// 菜单表
    /// </summary>
    [SugarTable("sys_menu")]
    public class SysMenu : EntityBase<long>
    {

        /// <summary>
        /// 菜单名称
        /// <summary>
        public string Name { get; set; }

        /// <summary>
        /// 父节点
        /// <summary>
        public long ParentId { get; set; }

        /// <summary>
        /// 父节点集合组
        /// <summary>
        public string ParentGroupId { get; set; }

        /// <summary>
        /// 权限标识
        /// <summary>
        public string Code { get; set; }

        /// <summary>
        /// 菜单层级
        /// <summary>
        public int Layer { get; set; } = 0;

        /// <summary>
        /// 路由地址
        /// <summary>
        public string Urls { get; set; }

        /// <summary>
        /// 菜单图标
        /// <summary>
        public string Icon { get; set; }

        /// <summary>
        /// 排序
        /// <summary>
        public int Sort { get; set; } = 1;

        /// <summary>
        /// 状态
        /// <summary>
        public bool Status { get; set; } = true;

        /// <summary>
        /// 是否删除
        /// <summary>
        public bool IsDel { get; set; } = false;

        /// <summary>
        /// 菜单类型：1=目录  2=菜单
        /// <summary>
        public int Types { get; set; } = 1;

        /// <summary>
        /// 菜单按钮
        /// <summary>
        public string BtnFun { get; set; }
    }
}