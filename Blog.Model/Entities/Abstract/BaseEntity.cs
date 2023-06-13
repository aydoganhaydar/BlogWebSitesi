using Blog.Model.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Blog.Model.Entities.Abstract
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }

		private DateTime _createdDate=DateTime.Now;

		public DateTime CreatedDate
		{
			get { return _createdDate; }
			set { _createdDate = value; }
		}

		public DateTime? UpdateDate { get; set; } //? nullable olarak işaretlemiş olduk. Yani ilk girişte boş geçilebilir.

		public DateTime? DeleteDate { get; set; }


		private Statu _statu=Statu.Active;

		public Statu Statu
		{
			get { return _statu; }
			set { _statu = value; }
		}

        private Onay _onay = Onay.UnApproved;

        public Onay Onay
        {
            get { return _onay; }
            set { _onay = value; }
        }

    }
}
