# Pivot Table Sample

## Original Data

| AGE_KBN_ORDERBY | AGE_KBN_NAME | AGE_KBN | MED_EXPENSE_SUM | HEADER |
| --------------- | ------------ | ------- | --------------- | ------ |
| 0.0             | 000-004 歳   | 000-004 | 37201130        |        |
| 0.0             | 000-004 歳   | 000-004 | 8371350         | 0      |
| 0.0             | 000-004 歳   | 000-004 | 11763980        | 1      |
| 0.0             | 000-004 歳   | 000-004 | 3048520         | 2      |
| 0.0             | 000-004 歳   | 000-004 | 12779930        | 3      |
| 0.0             | 000-004 歳   | 000-004 | 1237350         | 5      |
| 5.0             | 005-009 歳   | 005-009 | 20997060        |        |
| 5.0             | 005-009 歳   | 005-009 | 247770          | 0      |
| 5.0             | 005-009 歳   | 005-009 | 12184870        | 1      |
| 5.0             | 005-009 歳   | 005-009 | 4221740         | 2      |
| 5.0             | 005-009 歳   | 005-009 | 4342680         | 5      |
| 10.0            | 010-014 歳   | 010-014 | 30219940        |        |
| 10.0            | 010-014 歳   | 010-014 | 637700          | 0      |
| 10.0            | 010-014 歳   | 010-014 | 18906880        | 1      |
| 10.0            | 010-014 歳   | 010-014 | 4983830         | 2      |
| 10.0            | 010-014 歳   | 010-014 | 1917560         | 3      |
| 10.0            | 010-014 歳   | 010-014 | 151020          | 4      |
| 10.0            | 010-014 歳   | 010-014 | 3622950         | 5      |
| 15.0            | 015-019 歳   | 015-019 | 15190210        |        |
| 15.0            | 015-019 歳   | 015-019 | 755300          | 0      |
| 15.0            | 015-019 歳   | 015-019 | 7449840         | 1      |
| 15.0            | 015-019 歳   | 015-019 | 2859790         | 2      |
| 15.0            | 015-019 歳   | 015-019 | 2085780         | 3      |
| 15.0            | 015-019 歳   | 015-019 | 2039500         | 5      |
| 20.0            | 020-024 歳   | 020-024 | 23594090        |        |
| 20.0            | 020-024 歳   | 020-024 | 2003340         | 0      |
| 20.0            | 020-024 歳   | 020-024 | 7813970         | 1      |
| 20.0            | 020-024 歳   | 020-024 | 2489490         | 2      |
| 20.0            | 020-024 歳   | 020-024 | 8396460         | 3      |
| 20.0            | 020-024 歳   | 020-024 | 2890830         | 5      |
| 25.0            | 025-029 歳   | 025-029 | 24566770        |        |
| 25.0            | 025-029 歳   | 025-029 | 3424490         | 0      |
| 25.0            | 025-029 歳   | 025-029 | 8347010         | 1      |
| 25.0            | 025-029 歳   | 025-029 | 3705790         | 2      |
| 25.0            | 025-029 歳   | 025-029 | 4329660         | 3      |
| 25.0            | 025-029 歳   | 025-029 | 4759820         | 5      |
| 30.0            | 030-034 歳   | 030-034 | 27578350        |        |
| 30.0            | 030-034 歳   | 030-034 | 1671090         | 0      |
| 30.0            | 030-034 歳   | 030-034 | 8744730         | 1      |
| 30.0            | 030-034 歳   | 030-034 | 6819450         | 2      |
| 30.0            | 030-034 歳   | 030-034 | 5345020         | 3      |
| 30.0            | 030-034 歳   | 030-034 | 4998060         | 5      |
| 35.0            | 035-039 歳   | 035-039 | 25991190        |        |
| 35.0            | 035-039 歳   | 035-039 | 763440          | 0      |
| 35.0            | 035-039 歳   | 035-039 | 10880280        | 1      |
| 35.0            | 035-039 歳   | 035-039 | 2464890         | 2      |
| 35.0            | 035-039 歳   | 035-039 | 7438480         | 3      |
| 35.0            | 035-039 歳   | 035-039 | 4444100         | 5      |
| 40.0            | 040-044 歳   | 040-044 | 31583500        |        |
| 40.0            | 040-044 歳   | 040-044 | 1893010         | 0      |
| 40.0            | 040-044 歳   | 040-044 | 12884830        | 1      |
| 40.0            | 040-044 歳   | 040-044 | 4749070         | 2      |
| 40.0            | 040-044 歳   | 040-044 | 7068630         | 3      |
| 40.0            | 040-044 歳   | 040-044 | 4987960         | 5      |
| 45.0            | 045-049 歳   | 045-049 | 39681160        |        |
| 45.0            | 045-049 歳   | 045-049 | 4038700         | 0      |
| 45.0            | 045-049 歳   | 045-049 | 17005930        | 1      |
| 45.0            | 045-049 歳   | 045-049 | 6583430         | 2      |
| 45.0            | 045-049 歳   | 045-049 | 5644730         | 3      |
| 45.0            | 045-049 歳   | 045-049 | 6408370         | 5      |
| 50.0            | 050-054 歳   | 050-054 | 55998170        |        |
| 50.0            | 050-054 歳   | 050-054 | 3821400         | 0      |
| 50.0            | 050-054 歳   | 050-054 | 26345520        | 1      |
| 50.0            | 050-054 歳   | 050-054 | 7172300         | 2      |
| 50.0            | 050-054 歳   | 050-054 | 12340600        | 3      |
| 50.0            | 050-054 歳   | 050-054 | 6318350         | 5      |
| 55.0            | 055-059 歳   | 055-059 | 61047140        |        |
| 55.0            | 055-059 歳   | 055-059 | 6934710         | 0      |
| 55.0            | 055-059 歳   | 055-059 | 24345370        | 1      |
| 55.0            | 055-059 歳   | 055-059 | 9692740         | 2      |
| 55.0            | 055-059 歳   | 055-059 | 15078320        | 3      |
| 55.0            | 055-059 歳   | 055-059 | 4996000         | 5      |
| 60.0            | 060-064 歳   | 060-064 | 66791110        |        |
| 60.0            | 060-064 歳   | 060-064 | 15146700        | 0      |
| 60.0            | 060-064 歳   | 060-064 | 22575380        | 1      |
| 60.0            | 060-064 歳   | 060-064 | 6923810         | 2      |
| 60.0            | 060-064 歳   | 060-064 | 18040230        | 3      |
| 60.0            | 060-064 歳   | 060-064 | 4104990         | 5      |
| 65.0            | 065-069 歳   | 065-069 | 22834020        |        |
| 65.0            | 065-069 歳   | 065-069 | 1253180         | 0      |
| 65.0            | 065-069 歳   | 065-069 | 12133450        | 1      |
| 65.0            | 065-069 歳   | 065-069 | 3130930         | 2      |
| 65.0            | 065-069 歳   | 065-069 | 4343820         | 3      |
| 65.0            | 065-069 歳   | 065-069 | 1972640         | 5      |
| 70.0            | 070-074 歳   | 070-074 | 7052970         |        |
| 70.0            | 070-074 歳   | 070-074 | 3074640         | 0      |
| 70.0            | 070-074 歳   | 070-074 | 2264170         | 1      |
| 70.0            | 070-074 歳   | 070-074 | 1019100         | 2      |
| 70.0            | 070-074 歳   | 070-074 | 695060          | 5      |

## Pivot

| age_kbn_name |           | 0        | 1         | 2        | 3         | 4      | 5        | totals    |
| ------------ | --------- | -------- | --------- | -------- | --------- | ------ | -------- | --------- |
| 000-004 歳   | 37201130  | 8371350  | 11763980  | 3048520  | 12779930  |        | 1237350  | 74402260  |
| 005-009 歳   | 20997060  | 247770   | 12184870  | 4221740  |           |        | 4342680  | 41994120  |
| 010-014 歳   | 30219940  | 637700   | 18906880  | 4983830  | 1917560   | 151020 | 3622950  | 60439880  |
| 015-019 歳   | 15190210  | 755300   | 7449840   | 2859790  | 2085780   |        | 2039500  | 30380420  |
| 020-024 歳   | 23594090  | 2003340  | 7813970   | 2489490  | 8396460   |        | 2890830  | 47188180  |
| 025-029 歳   | 24566770  | 3424490  | 8347010   | 3705790  | 4329660   |        | 4759820  | 49133540  |
| 030-034 歳   | 27578350  | 1671090  | 8744730   | 6819450  | 5345020   |        | 4998060  | 55156700  |
| 035-039 歳   | 25991190  | 763440   | 10880280  | 2464890  | 7438480   |        | 4444100  | 51982380  |
| 040-044 歳   | 31583500  | 1893010  | 12884830  | 4749070  | 7068630   |        | 4987960  | 63167000  |
| 045-049 歳   | 39681160  | 4038700  | 17005930  | 6583430  | 5644730   |        | 6408370  | 79362320  |
| 050-054 歳   | 55998170  | 3821400  | 26345520  | 7172300  | 12340600  |        | 6318350  | 111996340 |
| 055-059 歳   | 61047140  | 6934710  | 24345370  | 9692740  | 15078320  |        | 4996000  | 122094280 |
| 060-064 歳   | 66791110  | 15146700 | 22575380  | 6923810  | 18040230  |        | 4104990  | 133582220 |
| 065-069 歳   | 22834020  | 1253180  | 12133450  | 3130930  | 4343820   |        | 1972640  | 45668040  |
| 070-074 歳   | 7052970   | 3074640  | 2264170   | 1019100  |           |        | 695060   | 14105940  |
| Totals       | 490326810 | 54036820 | 203646210 | 69864880 | 104809220 | 151020 | 57818660 | 980653620 |
