using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Found.MVC.Models
{
    public partial class template1Context : DbContext
    {
        public virtual DbSet<MsrPntHisDtCj> MsrPntHisDtCj { get; set; }
        public virtual DbSet<MsrPntHisDtWy> MsrPntHisDtWy { get; set; }
        public virtual DbSet<MsrPntHisDtZl> MsrPntHisDtZl { get; set; }
        public virtual DbSet<MsrPntRd> MsrPntRd { get; set; }
        public virtual DbSet<MsrPrjRd> MsrPrjRd { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(@"Server=120.24.187.193;Database=template1;User Id=pmcp;Password=pmcp;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("pgpool_recovery")
                .HasPostgresExtension("pgpool_regclass");

            modelBuilder.Entity<MsrPntHisDtCj>(entity =>
            {
                entity.ToTable("msr_pnt_his_dt_cj");

                entity.ForNpgsqlHasComment("沉降监测点历史数据");

                entity.Property(e => e.MsrPntHisDtCjId)
                    .HasColumnName("msr_pnt_his_dt_cj_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtTm)
                    .HasColumnName("crt_tm")
                    .HasDefaultValueSql("now()")
                    .ForNpgsqlHasComment("创建时间");

                entity.Property(e => e.CrtUsrId)
                    .HasColumnName("crt_usr_id")
                    .ForNpgsqlHasComment("创建人ID");

                entity.Property(e => e.CtlValue)
                    .HasColumnName("ctl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("控制值");

                entity.Property(e => e.CutValue)
                    .HasColumnName("cut_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("测量值");

                entity.Property(e => e.DefRateValue)
                    .HasColumnName("def_rate_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("变形速率");

                entity.Property(e => e.DtSrc)
                    .HasColumnName("dt_src")
                    .ForNpgsqlHasComment("数据来源");

                entity.Property(e => e.Extend1)
                    .HasColumnName("extend_1")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.Extend2)
                    .HasColumnName("extend_2")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.Extend3)
                    .HasColumnName("extend_3")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.Extend4)
                    .HasColumnName("extend_4")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.Extend5)
                    .HasColumnName("extend_5")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.Extend6)
                    .HasColumnName("extend_6")
                    .HasColumnType("numeric(16, 4)");

                entity.Property(e => e.InitValue)
                    .HasColumnName("init_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("初始值");

                entity.Property(e => e.MsrPntAmsId)
                    .HasColumnName("msr_pnt_ams_id")
                    .ForNpgsqlHasComment("自动监测监测点外键ID");

                entity.Property(e => e.MsrPntNm)
                    .HasColumnName("msr_pnt_nm")
                    .ForNpgsqlHasComment("点名称（测斜的时候为深度）");

                entity.Property(e => e.MsrPntRdId)
                    .HasColumnName("msr_pnt_rd_id")
                    .ForNpgsqlHasComment("监测点ID");

                entity.Property(e => e.MsrTm)
                    .HasColumnName("msr_tm")
                    .ForNpgsqlHasComment("测量时间");

                entity.Property(e => e.ThisDefValue)
                    .HasColumnName("this_def_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次变化值");

                entity.Property(e => e.TotalDefValue)
                    .HasColumnName("total_def_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("累积变化值");

                entity.Property(e => e.UpdTm)
                    .HasColumnName("upd_tm")
                    .ForNpgsqlHasComment("修改时间");

                entity.Property(e => e.UpdUsrId)
                    .HasColumnName("upd_usr_id")
                    .ForNpgsqlHasComment("修改人ID");

                entity.Property(e => e.Vld)
                    .HasColumnName("vld")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WrnValue)
                    .HasColumnName("wrn_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("预警值");

                entity.HasOne(d => d.MsrPntRd)
                    .WithMany(p => p.MsrPntHisDtCj)
                    .HasForeignKey(d => d.MsrPntRdId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("msr_pnt_his_dt_cj_msr_pnt_rd_id_fkey");
            });

            modelBuilder.Entity<MsrPntHisDtWy>(entity =>
            {
                entity.ToTable("msr_pnt_his_dt_wy");

                entity.ForNpgsqlHasComment("位移监测点历史数据");

                entity.Property(e => e.MsrPntHisDtWyId)
                    .HasColumnName("msr_pnt_his_dt_wy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CrtTm)
                    .HasColumnName("crt_tm")
                    .HasDefaultValueSql("now()")
                    .ForNpgsqlHasComment("创建时间");

                entity.Property(e => e.CrtUsrId)
                    .HasColumnName("crt_usr_id")
                    .ForNpgsqlHasComment("创建人ID");

                entity.Property(e => e.CtlValue)
                    .HasColumnName("ctl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("控制值");

                entity.Property(e => e.DefRateValueX)
                    .HasColumnName("def_rate_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("变形速率X");

                entity.Property(e => e.DefRateValueY)
                    .HasColumnName("def_rate_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("变形速率Y");

                entity.Property(e => e.DtSrc)
                    .HasColumnName("dt_src")
                    .ForNpgsqlHasComment("数据来源");

                entity.Property(e => e.InitValueX)
                    .HasColumnName("init_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("初始值X");

                entity.Property(e => e.InitValueY)
                    .HasColumnName("init_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("初始值Y");

                entity.Property(e => e.LastCutValueX)
                    .HasColumnName("last_cut_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("上次测量值X");

                entity.Property(e => e.LastCutValueY)
                    .HasColumnName("last_cut_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("上次测量值Y");

                entity.Property(e => e.MsrPntAmsId)
                    .HasColumnName("msr_pnt_ams_id")
                    .ForNpgsqlHasComment("自动化监测监测点外键ID");

                entity.Property(e => e.MsrPntNm)
                    .HasColumnName("msr_pnt_nm")
                    .ForNpgsqlHasComment("点名称（测斜的时候为深度）");

                entity.Property(e => e.MsrPntRdId)
                    .HasColumnName("msr_pnt_rd_id")
                    .ForNpgsqlHasComment("监测点ID");

                entity.Property(e => e.MsrTm)
                    .HasColumnName("msr_tm")
                    .ForNpgsqlHasComment("测量时间");

                entity.Property(e => e.ThisCutValueX)
                    .HasColumnName("this_cut_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次测量值X");

                entity.Property(e => e.ThisCutValueY)
                    .HasColumnName("this_cut_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次测量值Y");

                entity.Property(e => e.ThisDefValueX)
                    .HasColumnName("this_def_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次变化量X");

                entity.Property(e => e.ThisDefValueY)
                    .HasColumnName("this_def_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次变化量Y");

                entity.Property(e => e.TotalDefValueX)
                    .HasColumnName("total_def_value_x")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("累计变化量X");

                entity.Property(e => e.TotalDefValueY)
                    .HasColumnName("total_def_value_y")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("累计变化量Y");

                entity.Property(e => e.UpdTm)
                    .HasColumnName("upd_tm")
                    .ForNpgsqlHasComment("修改时间");

                entity.Property(e => e.UpdUsrId)
                    .HasColumnName("upd_usr_id")
                    .ForNpgsqlHasComment("修改人ID");

                entity.Property(e => e.Vld)
                    .HasColumnName("vld")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WrnValue)
                    .HasColumnName("wrn_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("预警值");

                entity.HasOne(d => d.MsrPntRd)
                    .WithMany(p => p.MsrPntHisDtWy)
                    .HasForeignKey(d => d.MsrPntRdId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("msr_pnt_his_dt_wy_msr_pnt_rd_id_fkey");
            });

            modelBuilder.Entity<MsrPntHisDtZl>(entity =>
            {
                entity.ToTable("msr_pnt_his_dt_zl");

                entity.ForNpgsqlHasComment("轴力监测点历史数据");

                entity.Property(e => e.MsrPntHisDtZlId)
                    .HasColumnName("msr_pnt_his_dt_zl_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AxlValue)
                    .HasColumnName("axl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("轴力计算值");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("crt_tm")
                    .HasDefaultValueSql("now()")
                    .ForNpgsqlHasComment("创建时间");

                entity.Property(e => e.CrtUsrId)
                    .HasColumnName("crt_usr_id")
                    .ForNpgsqlHasComment("创建人ID");

                entity.Property(e => e.CtlValue)
                    .HasColumnName("ctl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("控制值");

                entity.Property(e => e.CutValue)
                    .HasColumnName("cut_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("测量读数");

                entity.Property(e => e.DtSrc)
                    .HasColumnName("dt_src")
                    .ForNpgsqlHasComment("数据来源");

                entity.Property(e => e.InitValue)
                    .HasColumnName("init_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("初始读数");

                entity.Property(e => e.KValue)
                    .HasColumnName("k_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment(" K值 *10-3（KN/Hz²）压");

                entity.Property(e => e.MsrPntAmsId)
                    .HasColumnName("msr_pnt_ams_id")
                    .ForNpgsqlHasComment("自动化监测监测点外键ID");

                entity.Property(e => e.MsrPntNm)
                    .HasColumnName("msr_pnt_nm")
                    .ForNpgsqlHasComment("点名称（测斜的时候为深度）");

                entity.Property(e => e.MsrPntRdId)
                    .HasColumnName("msr_pnt_rd_id")
                    .ForNpgsqlHasComment("监测点ID");

                entity.Property(e => e.MsrTm)
                    .HasColumnName("msr_tm")
                    .ForNpgsqlHasComment("测量时间");

                entity.Property(e => e.ThisDefAxlValue)
                    .HasColumnName("this_def_axl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("本次轴力变化值");

                entity.Property(e => e.TotalDefAxlValue)
                    .HasColumnName("total_def_axl_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("累积轴力变化值");

                entity.Property(e => e.UpdTm)
                    .HasColumnName("upd_tm")
                    .ForNpgsqlHasComment("修改时间");

                entity.Property(e => e.UpdUsrId)
                    .HasColumnName("upd_usr_id")
                    .ForNpgsqlHasComment("修改人ID");

                entity.Property(e => e.Vld)
                    .HasColumnName("vld")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WrnValue)
                    .HasColumnName("wrn_value")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("预警值");

                entity.HasOne(d => d.MsrPntRd)
                    .WithMany(p => p.MsrPntHisDtZl)
                    .HasForeignKey(d => d.MsrPntRdId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("msr_pnt_his_dt_zl_msr_pnt_rd_id_fkey");
            });

            modelBuilder.Entity<MsrPntRd>(entity =>
            {
                entity.ToTable("msr_pnt_rd");

                entity.ForNpgsqlHasComment("监测点");

                entity.Property(e => e.MsrPntRdId)
                    .HasColumnName("msr_pnt_rd_id")
                    .HasDefaultValueSql("NULL::character varying")
                    .ForNpgsqlHasComment("ID");

                entity.Property(e => e.BimMdlId)
                    .HasColumnName("bim_mdl_id")
                    .ForNpgsqlHasComment("模型关联ID");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("crt_tm")
                    .HasDefaultValueSql("now()")
                    .ForNpgsqlHasComment("创建时间");

                entity.Property(e => e.CrtUsrId)
                    .HasColumnName("crt_usr_id")
                    .ForNpgsqlHasComment("创建人ID");

                entity.Property(e => e.Dscr)
                    .HasColumnName("dscr")
                    .ForNpgsqlHasComment("描述");

                entity.Property(e => e.IsAsm)
                    .HasColumnName("is_asm")
                    .HasDefaultValueSql("0")
                    .ForNpgsqlHasComment("是否自动化监测");

                entity.Property(e => e.MsrPntNm)
                    .HasColumnName("msr_pnt_nm")
                    .ForNpgsqlHasComment("监测点名称");

                entity.Property(e => e.MsrPrjRdId)
                    .HasColumnName("msr_prj_rd_id")
                    .ForNpgsqlHasComment("监测项目ID");

                entity.Property(e => e.MsrSt)
                    .HasColumnName("msr_st")
                    .ForNpgsqlHasComment("0：未监测
1：监测中
2：不再监测");

                entity.Property(e => e.MsrTpCd)
                    .IsRequired()
                    .HasColumnName("msr_tp_cd")
                    .ForNpgsqlHasComment("监测类型");

                entity.Property(e => e.UpdTm)
                    .HasColumnName("upd_tm")
                    .ForNpgsqlHasComment("修改时间");

                entity.Property(e => e.UpdUsrId)
                    .HasColumnName("upd_usr_id")
                    .ForNpgsqlHasComment("修改人ID");

                entity.Property(e => e.Vld)
                    .HasColumnName("vld")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WrnLvlTpCdC)
                    .HasColumnName("wrn_lvl_tp_cd_c")
                    .ForNpgsqlHasComment("预警级别（累计预警）");

                entity.Property(e => e.WrnLvlTpCdR)
                    .HasColumnName("wrn_lvl_tp_cd_r")
                    .ForNpgsqlHasComment("速率预警级别");

                entity.HasOne(d => d.MsrPrjRd)
                    .WithMany(p => p.MsrPntRd)
                    .HasForeignKey(d => d.MsrPrjRdId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("msr_pnt_rd_msr_prj_rd_id_fkey");
            });

            modelBuilder.Entity<MsrPrjRd>(entity =>
            {
                entity.ToTable("msr_prj_rd");

                entity.ForNpgsqlHasComment("监测项目");

                entity.Property(e => e.MsrPrjRdId)
                    .HasColumnName("msr_prj_rd_id")
                    .HasDefaultValueSql("NULL::character varying")
                    .ForNpgsqlHasComment("ID");

                entity.Property(e => e.CrtTm)
                    .HasColumnName("crt_tm")
                    .HasDefaultValueSql("now()")
                    .ForNpgsqlHasComment("创建时间");

                entity.Property(e => e.CrtUsrId)
                    .HasColumnName("crt_usr_id")
                    .ForNpgsqlHasComment("创建人ID");

                entity.Property(e => e.Dscr)
                    .HasColumnName("dscr")
                    .ForNpgsqlHasComment("描述");

                entity.Property(e => e.IsAsm)
                    .HasColumnName("is_asm")
                    .HasDefaultValueSql("0")
                    .ForNpgsqlHasComment("是否自动化监测");

                entity.Property(e => e.MsrDtSrc)
                    .HasColumnName("msr_dt_src")
                    .ForNpgsqlHasComment("数据来源");

                entity.Property(e => e.MsrPntMarked)
                    .HasColumnName("msr_pnt_marked")
                    .ForNpgsqlHasComment("标示监测点，用于判断监测项修正");

                entity.Property(e => e.MsrPrjNm)
                    .HasColumnName("msr_prj_nm")
                    .ForNpgsqlHasComment("监测项目名称");

                entity.Property(e => e.MsrTpCd)
                    .IsRequired()
                    .HasColumnName("msr_tp_cd")
                    .ForNpgsqlHasComment("监测类型");

                entity.Property(e => e.PrjStrcId)
                    .HasColumnName("prj_strc_id")
                    .ForNpgsqlHasComment("项目ID");

                entity.Property(e => e.UntNm)
                    .HasColumnName("unt_nm")
                    .ForNpgsqlHasComment("单位名称");

                entity.Property(e => e.UpdTm)
                    .HasColumnName("upd_tm")
                    .ForNpgsqlHasComment("修改时间");

                entity.Property(e => e.UpdUsrId)
                    .HasColumnName("upd_usr_id")
                    .ForNpgsqlHasComment("修改人ID");

                entity.Property(e => e.Vld)
                    .HasColumnName("vld")
                    .HasDefaultValueSql("1");

                entity.Property(e => e.WrnCtrlRV)
                    .HasColumnName("wrn_ctrl_r_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("预警控制值【速率变化】");

                entity.Property(e => e.WrnCtrlTV)
                    .HasColumnName("wrn_ctrl_t_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("预警控制值【累计变化】");

                entity.Property(e => e.WrnORP)
                    .HasColumnName("wrn_o_r_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("橙色预警速率变化百分比");

                entity.Property(e => e.WrnORV)
                    .HasColumnName("wrn_o_r_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("橙色预警速率变化值");

                entity.Property(e => e.WrnOTP)
                    .HasColumnName("wrn_o_t_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("橙色预警累计变化百分比");

                entity.Property(e => e.WrnOTV)
                    .HasColumnName("wrn_o_t_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("橙色预警累计变化值");

                entity.Property(e => e.WrnRRP)
                    .HasColumnName("wrn_r_r_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("红色预警速率变化百分比");

                entity.Property(e => e.WrnRRV)
                    .HasColumnName("wrn_r_r_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("红色预警速率变化值");

                entity.Property(e => e.WrnRTP)
                    .HasColumnName("wrn_r_t_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("红色预警累计变化百分比");

                entity.Property(e => e.WrnRTV)
                    .HasColumnName("wrn_r_t_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("红色预警累计变化值");

                entity.Property(e => e.WrnYRP)
                    .HasColumnName("wrn_y_r_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("黄色预警速率变化百分比");

                entity.Property(e => e.WrnYRV)
                    .HasColumnName("wrn_y_r_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("黄色预警速率变化值");

                entity.Property(e => e.WrnYTP)
                    .HasColumnName("wrn_y_t_p")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("黄色预警累计变化百分比");

                entity.Property(e => e.WrnYTV)
                    .HasColumnName("wrn_y_t_v")
                    .HasColumnType("numeric(16, 4)")
                    .ForNpgsqlHasComment("黄色预警累计变化值");
            });
        }
    }
}
