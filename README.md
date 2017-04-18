This repository contains a small example of a C# project that writes structured and non  structured log messages to a elastic search instance.

In order to start elastic search, execute the ``docker run -p 5601:5601 -p 9200:9200 -p 5044:5044 -it --name elk sebp/elk:E1L1K4`` command. 
Kibana 4 should be available under the address ``http://localhost:5601/``.

When you run the C# project, you should get two messages on Elastic Search:

* A non structured one: 

``
{
  "_index": "logstash-2017.XX.XX",
  "_type": "logevent",
  "_id": "AVuAMEEEw0XhhqDFYfnd",
  "_score": null,
  "_source": {
    "@timestamp": "XXX",
    "level": "Info",
    "message": "{  }"
  },
  "fields": {
    "@timestamp": [
	XXX
    ]
  },
  "sort": [
	XXX
  ]
}
``
* A structured one: 
``
{
  "_index": "logstash-2017.XX.XX",
  "_type": "logevent",
  "_id": "AVuAMEEHw0XhhqDFYfne",
  "_score": null,
  "_source": {
    "@timestamp": "XXX",
    "level": "Info",
    "message": "{ \"Name\": \"Tom\", \"Age\": 34 }"
  },
  "fields": {
    "@timestamp": [
	XXX
    ]
  },
  "sort": [
	XXX
  ]
}
`` 
