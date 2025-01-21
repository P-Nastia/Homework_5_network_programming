using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovaPoshta.Data.Entities;

public class WorkScheduleEntity
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Monday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Tuesday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Wednesday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Thursday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Friday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Saturday { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Sunday { get; set; } = string.Empty;
}
