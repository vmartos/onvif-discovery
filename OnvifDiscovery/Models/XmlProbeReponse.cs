﻿using System.Xml.Serialization;

namespace OnvifDiscovery.Models
{
	[XmlRoot ("Envelope", Namespace = "http://www.w3.org/2003/05/soap-envelope")]
	internal class XmlProbeReponse
	{
		[XmlElement (Namespace = "http://www.w3.org/2003/05/soap-envelope")]
		public Header Header { get; set; }

		[XmlElement (Namespace = "http://www.w3.org/2003/05/soap-envelope")]
		public Body Body { get; set; }
	}

	internal class Header
	{
		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		public string MessageID { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		public string RelatesTo { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		public string To { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public string AppSequence { get; set; }
	}

	internal class Body
	{
		[XmlArray (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public ProbeMatch[] ProbeMatches { get; set; }
	}

	internal class ProbeMatch
	{
		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		public EndpointReference EndpointReference { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public string Types { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public string Scopes { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public string XAddrs { get; set; }

		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2005/04/discovery")]
		public string MetadataVersion { get; set; }
	}

	internal class EndpointReference
	{
		[XmlElement (Namespace = "http://schemas.xmlsoap.org/ws/2004/08/addressing")]
		public string Address { get; set; }
	}
}
