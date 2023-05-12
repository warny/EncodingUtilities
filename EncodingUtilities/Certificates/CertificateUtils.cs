using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EncodingUtilities.Certificates
{
	class CertificateUtils
	{
		public static string ReadCertificatContent( X509Certificate2 cer )
		{
			StringBuilder target = new StringBuilder();
			target.AppendFormat("Name = {0}", cer.FriendlyName).AppendLine();
			target.AppendFormat("Private Key = {0}", cer.HasPrivateKey).AppendLine();
			target.AppendFormat("Subject = {0}", cer.Subject).AppendLine();
			target.AppendFormat("Issuer = {0}", cer.Issuer).AppendLine();
			target.AppendFormat("IssuerName = {0}", cer.IssuerName.Name).AppendLine();
			target.AppendFormat("IssuerOid = {0} | {1}", cer.IssuerName.Oid.FriendlyName, cer.IssuerName.Oid.Value).AppendLine();
			target.AppendFormat("SerialNumber = {0}", cer.SerialNumber).AppendLine();
			target.AppendFormat("Valid From = {0}", cer.NotBefore).AppendLine();
			target.AppendFormat("Valid To = {0}", cer.NotAfter).AppendLine();
			target.AppendFormat("Version = {0}", cer.Version).AppendLine();
			target.AppendFormat("Thumbprint = {0}", cer.Thumbprint).AppendLine();

			target.AppendLine("Extensions : ");
			foreach (var extension in cer.Extensions) {
				string value = extension.Format(false);
				target.AppendFormat("\t{0} ({1}) = {2}", extension.Oid.FriendlyName, extension.Oid.Value, value);
				target.AppendLine();
			}

			return target.ToString();
		}
	}
}
