﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel: INotifyPropertyChanged
    {
        private string _text;
        private bool _isDone;

        public DateTime CreationDate { get; set; } = DateTime.Now;

		public bool IsDone
		{
			get { return _isDone; }
			set 
			{
				if (_isDone == value) return;
				_isDone = value;
				OnPropertyChanged("IsDone");

            }
		}

		public string Text
		{
			get { return _text; }
			set 
			{
				if(_text == value) return;
				_text = value;
				OnPropertyChanged("Text");
            }
		}

        public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string properyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(properyName));
		}
    }
}
