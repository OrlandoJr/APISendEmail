using APISendEmail.Interfaces;
using System;
using System.Configuration;

namespace APISendEmail.Models
{
	public class EmailConfiguration : IEmailConfiguration
	{
		public string SmtpServer { get; set; }
		public int    SmtpPort { get; set; }
		public string SmtpUsername { get; set; }
		public string SmtpPassword { get; set; }
		public bool UseSSL { get; set; }

		public string PopServer { get; set; }
		public int    PopPort { get; set; }
		public string PopUsername { get; set; }
		public string PopPassword { get; set; }

		public EmailConfiguration()
        {
			var config = ConfigurationManager.AppSettings;
			SmtpServer   = config["SmtpServer"];
		    SmtpPort 	 = Convert.ToInt32(config["SmtpPort"]);
			SmtpUsername = config["SmtpUsername"];
			SmtpPassword = config["SmtpPassword"];
			UseSSL       = Convert.ToBoolean(config["UseSSL"]);
			PopServer	 = config["PopServer"];
			PopPort      = Convert.ToInt32(config["PopPort"]);
		    PopUsername	 = config["PopUsername"];
			PopPassword  = config["PopPassword"];
			
		}
	}
}