using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_BackendAPI.Models
{
    public class PaymentDetailDBContext:DbContext
    {
        public PaymentDetailDBContext(DbContextOptions<PaymentDetailDBContext> options) : base(options){

        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }
    }
}
