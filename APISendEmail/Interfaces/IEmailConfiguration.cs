﻿
namespace APISendEmail.Interfaces
{
	public interface IEmailConfiguration
	{
		
		string SmtpServer { get; }
		int SmtpPort { get; }
		string SmtpUsername { get; set; }
		string SmtpPassword { get; set; }
		bool UseSSL { get; set; }

		string PopServer { get; }
		int PopPort { get; }
		string PopUsername { get; }
		string PopPassword { get; }
	}
}