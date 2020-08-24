ı
à/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Factories/IFactory.cs
	namespace 	
DomainService
 
. 
Domain 
. 
	Factories (
{ 
public 
	interface	 
IFactory 
{ 
AModel		 

Create		 
(		 
string		 
s		 
)		 
;		 
} 
} º

å/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Factories/SpaceFactory.cs
	namespace 	
DomainService
 
. 
Domain 
. 
	Factories (
{ 
public 
class	 
SpaceFactory 
: 
IFactory &
{ 
public		 

AModel		 
Create		 
(		 
string		 
s		  !
)		! "
{

 
if 
(	 

s
 
. 
ToUpper 
( 
) 
. 
Equals 
( 
$str %
)% &
)& '
{' (
return 
new 
PlanetModel 
( 
)  
;  !
} 
else 
if 
( 
s 
. 
ToUpper 
( 
) 
. 
Equals #
(# $
$str$ *
)* +
)+ ,
{, -
return 
new 
	StarModel 
( 
) 
; 
} 
return 
null 
; 
} 
} 
} ”
Å/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/JSONConvert.cs
	namespace 	
DomainService
 
. 
Domain 
{ 
public 
class	 
JSONConvert 
{		 
public 

string 
Convert 
( 
	StarModel #
star$ (
)( )
{) *
return 
JsonConvert 
. 
SerializeObject (
(( )
star) -
)- .
;. /
} 
public 

string 
Convert 
( 
ConstellationModel ,
constellation- :
): ;
{; <
return 
JsonConvert 
. 
SerializeObject (
(( )
constellation) 6
)6 7
;7 8
} 
public 

string 
Convert 
( 
PlanetModel %
planet& ,
), -
{- .
return 
JsonConvert 
. 
SerializeObject (
(( )
planet) /
)/ 0
;0 1
} 
public 

string 
Convert 
( 
SolarSystemModel *
solarSystem+ 6
)6 7
{7 8
return 
JsonConvert 
. 
SerializeObject (
(( )
solarSystem) 4
)4 5
;5 6
}!! 
public## 

string## 
Convert## 
(## 
List## 
<## 
	StarModel## (
>##( )
stars##* /
)##/ 0
{##0 1
return%% 
JsonConvert%% 
.%% 
SerializeObject%% (
(%%( )
stars%%) .
)%%. /
;%%/ 0
}'' 
public)) 

string)) 
Convert)) 
()) 
List)) 
<)) 
ConstellationModel)) 1
>))1 2
constellations))3 A
)))A B
{))B C
return++ 
JsonConvert++ 
.++ 
SerializeObject++ (
(++( )
constellations++) 7
)++7 8
;++8 9
}-- 
public// 

string// 
Convert// 
(// 
List// 
<// 
PlanetModel// *
>//* +
planets//, 3
)//3 4
{//4 5
return11 
JsonConvert11 
.11 
SerializeObject11 (
(11( )
planets11) 0
)110 1
;111 2
}33 
public55 

string55 
Convert55 
(55 
List55 
<55 
SolarSystemModel55 /
>55/ 0
solarSystems551 =
)55= >
{55> ?
return77 
JsonConvert77 
.77 
SerializeObject77 (
(77( )
solarSystems77) 5
)775 6
;776 7
}99 
};; 
}== ∞
É/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/AModel.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 
abstract	 
class 
AModel 
{ 
public 

int 
Id 
{ 
get 
; 
set 
; 
} 
public		 

string		 
Name		 
{		 
get		 
;		 
set		 
;		  
}		  !
} 
} ·
è/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/ConstellationModel.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class 
ConstellationModel #
:$ %
AModel& ,
{		 
[ 
	NotMapped 
] 
public 
List 
< 
	StarModel 
> 
Stars "
{# $
get$ '
;' (
set( +
;+ ,
}, -
public 
string 
Description 
{  !
get! $
;$ %
set% (
;( )
}) *
public 
ConstellationModel 
(  
)  !
{! "
Stars 
= 
new 
List 
< 
	StarModel "
>" #
(# $
)$ %
;% &
} 
} 
} á
à/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/PlanetModel.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class 
PlanetModel 
: 
AModel %
{ 
public		 
double		 
Radius		 
{		 
get		 
;		  
set		  #
;		# $
}		$ %
public 
double 
Mass 
{ 
get 
; 
set !
;! "
}" #
public 
double 
Volume 
{ 
get 
;  
set  #
;# $
}$ %
public 
string 
Description 
{  !
get! $
;$ %
set% (
;( )
}) *
} 
} Ï
î/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/PlanetSolarSystJunction.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class #
PlanetSolarSystJunction (
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		 
public 
PlanetModel 
Planet 
{  !
get! $
;$ %
set% (
;( )
}) *
public 
SolarSystemModel 
SolarSystem )
{* +
get+ .
;. /
set/ 2
;2 3
}3 4
} 
} „
ç/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/SolarSystemModel.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class 
SolarSystemModel !
:" #
AModel$ *
{		 
[ 
	NotMapped 
] 
public 
List 
< 
PlanetModel 
> 
Planets &
{' (
get( +
;+ ,
set, /
;/ 0
}0 1
public 
string 
Description 
{  !
get! $
;$ %
set% (
;( )
}) *
public 
SolarSystemModel 
( 
) 
{  
Planets 
= 
new 
List 
< 
PlanetModel &
>& '
(' (
)( )
;) *
} 
} 
} ‡
é/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/StarConstJunction.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class 
StarConstJunction "
{ 
public		 
int		 
Id		 
{		 
get		 
;		 
set		 
;		 
}		 
public 
	StarModel 
Star 
{ 
get  
;  !
set! $
;$ %
}% &
public 
ConstellationModel 
Constellation  -
{. /
get/ 2
;2 3
set3 6
;6 7
}7 8
} 
} ä
Ü/home/jchionglo/2007_13_dotnet/project-challenges/project-challenge-p2-revadex/Domain.Service/DomainService.Domain/Models/StarModel.cs
	namespace 	
DomainService
 
. 
Domain 
. 
Models %
{ 
public 

class 
	StarModel 
: 
AModel #
{ 
public		 
double		 
Distance		 
{		 
get		 !
;		! "
set		" %
;		% &
}		& '
public 
double 
Temperature 
{  !
get! $
;$ %
set% (
;( )
}) *
public 
double 
Mass 
{ 
get 
; 
set !
;! "
}" #
public 
string 
Description 
{  !
get! $
;$ %
set% (
;( )
}) *
} 
} 