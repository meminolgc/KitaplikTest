﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kitaplik_Test
{
	class Kitap
	{
		int id;
		string ad;
		string yazar;

		public int ID
		{
			get { return id; }
			set { id = value; }
		}
		public string Adı
		{
			get { return ad; }
			set { ad = value; }

		}
		public string Yazarı
		{
			get { return yazar; }
			set { yazar = value; }
		}

	}
}
