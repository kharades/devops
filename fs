
#
# /etc/fstab
# Created by anaconda on Sun Mar  1 16:17:23 2020
#
# Accessible filesystems, by reference, are maintained under '/dev/disk'
# See man pages fstab(5), findfs(8), mount(8) and/or blkid(8) for more info
#
UUID=765aba12-4e19-4fc0-a100-b3223b9cf94a /                       xfs     defaults        0 0
UUID=8c03f91d-fe5f-4c3b-8a8e-34eaef7ecb5a /boot                   xfs     defaults        0 0
/dev/sdb4				/tmp			ext4	defaults 	0 0
#/dev/loop1 				/mnt/disc		ext4 defaults 0 0
/dev/sdc1 		/rhel		ext4 defaults 0 0
/dev/sdb2		/var	ext4 defaults 0 0

/dev/mapper/myvg2-mylvm	/home/sagar	ext4	defaults	1 2
