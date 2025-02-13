﻿using System.Text.Json.Serialization;

namespace DtnParkingSystem.Services
{
	public class FirebaseSettings
	{
		[JsonPropertyName("project_id")]
		public string ProjectId => "dtn-parking-manager";

		[JsonPropertyName("private_key_id")]
		public string PrivateKeyId => "8bed3b8b7163a0b9a66fc83c91a23398f01b169e";

		[JsonPropertyName("type")]
		public string type => "service_account";
		[JsonPropertyName("private_key")]
		public string private_key => "-----BEGIN PRIVATE KEY-----\nMIIEvwIBADANBgkqhkiG9w0BAQEFAASCBKkwggSlAgEAAoIBAQCbQUpDpPS41Mcx\nCifmQf0th28K8tTtdX1Hxc8NA+x6NcWGLZlQ9u/P/MuVuLOMVzqqYAiPjWsXUvx8\nAaDQ1vQD6AOVQ5UnMNWCP6vXO2CU15Dw4jE8h9Xyz9nB96zyvFzGwNHnLj57PZZD\nVMY97S/kMLG2iKVBpUyc3Hgp73BLG1IEbtgaKhc4zXV2tVyhvMuNdex5L2SrHTBL\nDMAijl+3WcORt2IhL32iYQXocfoGxB/dbSVN4ioPCN480AnFa4oLFkQ8CA3e/Ozz\nctGh9xV1hZQw0ukFZFB6zGuf1Hqyqd9xAGpeY7sSP+O630NCXhJcP8wD5i4SnLH1\ndat9aPlXAgMBAAECggEAOB1robJ0D4A8tNFmZXexcizS6mKlqmQ+UVxCP4KNDQj1\naU9+7EAsooDM9sMpBk8a8ay/O1+Sdv40KwANp54h2W2ZKfCg7ubcLPUlf6hC+tlF\nVoNy511za41LuCt0k9GYOPBFjejthW7XqmNwOb7KghBFk2OlU2pTHBklx4Z3EHXx\nZCqlKvz0VEIGD4onlomSuYfjlNNy4YknSS63lLQFV8WoEHsXcap+XG2Ad0FH3OfZ\no6VAjz4NMLy6uY0ruSkRHjrkvVzlIA203pGA/E9sQ3/PgFjLbHAN6llASK0EnD7E\n4W51hSy+Yg3x9wvycXsrpU+IcbJLd0jBzAZdWtG1dQKBgQDYFPGPOjLT8qgveNkH\nVaszg4Qsr6XyjQcm4lJ3+CoYC/YlQCJUvkSsB6vj4LiYhQWBQPNO5QIIGAsuosDw\nWCvDOn2Nxs+VEtPpwepwBjpNN/CsYC9WgDZmAadpdZ3eRksbl5SHkJinKHbXB+Xm\nDCcj0uKfAT42OkK9ZMhum2MIUwKBgQC377HAPFGvTWeDi2AtMbq4piXOoP4evn0s\ncAcscgyLisiDN7lP1/kGWGDxzKdY9MaxNJSNGmxpzcW/UA0WD+RLYsbycmokiy1c\n//oRqwlJcZdm60J/Wc8+qfAorYUTMZRMTn6DVHjaxBSJ+92OivnG3ORwNrDs+5ur\nNPrMYEIabQKBgQCHGhEujCTbgAzIIbcQbu/r9X7esbQAQ00Fctw9RlyLTG9KOx87\n/PrS1LkUcZz5P7KBbiqyWV070kyri/c2TuqN1jRKQNPpUSxOK4B5KmupfCBupnTy\nkJdyj/Ysae2a3Dh5t/yWBkJrwVEMgVOs0kxmiaRH5m8PWL4BzNHE1kLFIQKBgQCM\nu0F2AvDAvumHdTk1+wmRQ9ZDfVxRa4/cUy6569z7W0lFVHpdw7IOD8rE1r/nyQjJ\nBqDuQRxX64/0a6xHiAs1PrNXRwE9Spt/v362y/VEEzwzC6eKRs3RdTaB+RmLcPC1\nXY1gsF3zi/jnBiUjbePkKphB3yaJe41Edjm566BIFQKBgQClJr7/dbfUQBJbX071\nQlPonZL6kLxGUC7BxDdY/wLWaA/uBdhQN/wax8FSWcJytSrVlA23tkFZuF6sgcFU\niHK6xUNyrXDd8YnPbPR+GvOMuEkV3ALNSMb4uiI537+rHFu93oxuhhql2hupOuWa\nL+tz7zUK5dJrOz85AEE6urTGAg==\n-----END PRIVATE KEY-----\n";

		[JsonPropertyName("client_email")]
		public string Client_email => "firebase-adminsdk-ppq8k@dtn-parking-manager.iam.gserviceaccount.com";

		[JsonPropertyName("client_id")]
		public string Client_id => "113248074069740699754";

		[JsonPropertyName("auth_uri")]
		public string auth_uri => "https://accounts.google.com/o/oauth2/auth";

		[JsonPropertyName("token_uri")]
		public string token_uri => "https://oauth2.googleapis.com/token";

		public string auth_provider_x509_cert_url => "https://www.googleapis.com/oauth2/v1/certs";

		[JsonPropertyName("client_x509_cert_url")]
		public string client_x509_cert_url => "\"https://www.googleapis.com/robot/v1/metadata/x509/firebase-adminsdk-ppq8k%40dtn-parking-manager.iam.gserviceaccount.com\"";

	}

}
