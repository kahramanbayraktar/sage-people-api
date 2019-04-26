**AUTHENTICATION**

| | Value |
|--|--|
| Action | Get Token |
| Endpoint | https://login.salesforce.com/services/oauth2/token |
| HttpMethod | POST |

<br/>

| Param | Value |
|--|--|
| grant_type | password |
| client_id | xxx |
| client_secret | xxx |
| username | xxx@xxx.com |
| password | xxx |

    Note: Client id and client secret must be obtained by creating a connected app in Sage People HCM Admin Portal. Refer to the Requirements section below.

**Request URL with params**
`https://login.salesforce.com/services/oauth2/token?grant_type=password&client_id=xxx&client_secret=xxx&username=xxx@xxx.com&password=xxx`

<br/>

|  | Response |
|--|--|
| access_token | xxx |
| instance_url | https://xxx.cloudforce.com |
| id | https://login.salesforce.com/id/00D0O000000sv28UAA/0050O000009hhvSQAQ |
| token_type | Bearer |
| issued_at | 1555841125808 |
| signature | m0erIwS9ekZfti835fFG3nkHtnhLec3KVDArcAzxIdU= |

<br/>

---

**LIST VACANCIES**

| | Value |
|--|--|
| Action | List Vacancies |
| Endpoint | https://na1.salesforce.com/services/data/v45.0/query |
| HttpMethod | GET |
| AuthorizationType | Bearer Token |

<br/>

| Header | Value |
|--|--|
| Authorization | Bearer Token |

<br/>

| Param | Value |
|--|--|
| q | select+id,name,fRecruit__Location_City__c,fRecruit__Location_Country__c,fRecruit__Location_Region__c+from+fRecruit__Vacancy__c |

**Request URL with params**
`https://na1.salesforce.com/services/data/v45.0/query/?q=select+id,name,fRecruit__Location_City__c,fRecruit__Location_Country__c,fRecruit__Location_Region__c+from+fRecruit__Vacancy__c`

    How to Execute a SOQL Query: https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/dome_query.htm

<br/>

---

**GET VACANCY**

| | Value |
|--|--|
| Action | Get Vacancy |
| Endpoint | https://na1.salesforce.com/services/data/v45.0/sobjects/fRecruit__Vacancy__c/{id} |
| HttpMethod | GET |
| AuthorizationType | Bearer Token |

| Header | Value |
|--|--|
| Authorization | Bearer Token |

**Request URL with params**
`https://na1.salesforce.com/services/data/v45.0/sobjects/fRecruit__Vacancy__c/a2S0O00000IrIFKUA3`

<br/>

---

**REQUIREMENTS**

1) Make sure you have the correct credentials (test it against https://login.salesforce.com).

2) Make sure your account has enough permissions (check it on Profiles page https://xxx.cloudforce.com/setup/ui/profilelist.jsp).
How to go there:
   - Log in through https://login.salesforce.com 
   - Go to https://xxx.cloudforce.com
   - Click Setup on the top menu
   - Click Manage Users on the left side menu
   - Click Profiles on the left side menu
   - Locate your account's profile
   - Click Edit
   - Check the Custom Object Permissions section

3) Make sure you have created a connected app and you have **Client Id** (consumer key) and **Client Secret** (consumer secret). Refer to https://developer.salesforce.com/docs/atlas.en-us.api_rest.meta/api_rest/intro_defining_remote_access_applications.htm.

4) Make sure you use the correct object name on your queries. For instance, for vacancies, the name of the object is **fRecruit__Vacancy__c**. You can reach all object names from https://na1.salesforce.com/services/data/v45.0/sobjects. Also, take a look at https://developer.salesforce.com/docs/atlas.en-us.object_reference.meta/object_reference/sforce_api_objects_custom_object__c.htm to learn more about custom objects.

<br/>

---

**API ENDPOINTS**

| Task | URL |
|--|--|
| API Versions | https://na1.salesforce.com/services/data |
| Resources | https://na1.salesforce.com/services/data/v45.0  |
| Custom Object Definition List | https://na1.salesforce.com/services/data/v45.0/sobjects |
| Query Custom Objects | https://na1.salesforce.com/services/data/v45.0/query?q={query} |
| Single Custom Object | https://na1.salesforce.com/services/data/v45.0/sobjects/{classname}/{objectid} |

<br/>

---

**API ERRORS**

If your account doesn't have needed permissions you'll get this error:

    "message": "... sObject type 'fRecruit__Vacancy__c' is not supported. If you are attempting to use a custom object, be sure to append the '__c' after the entity name. Please reference your WSDL or the describe call for the appropriate names.",
    "errorCode": "INVALID_TYPE"

Check and update, if needed, your account's permissions on this page: https://xxx.cloudforce.com/setup/ui/profilelist.jsp

<br/>

---

**Important Pages in Sage People HCM Admin Portal**

Home Page: https://xxx.cloudforce.com

All Tabs: https://xxx.cloudforce.com/home/showAllTabs.jsp

Vacancies: [https://xxx--frecruit.eu9.visual.force.com/apex/fRecruitVacancyTab](https://xxx--frecruit.eu9.visual.force.com/apex/fRecruitVacancyTab)

Setup Page: https://xxx.cloudforce.com/setup/forcecomHomepage.apexp

Profiles Page: https://xxx.cloudforce.com/setup/ui/profilelist.jsp

Users Page: https://xxx.cloudforce.com/005

<br/>

---

**Live Examples**

https://thepalladiumgroup.com/jobs

https://www.u-blox.com/en/job-openings
