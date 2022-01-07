

import os, sys, glob


testing_directory = os.path.dirname(os.path.realpath(__file__))
test_data_dir = os.path.join(testing_directory, "test_data")
roadrunner_directory = os.path.dirname(testing_directory)
rr_site_packages_dir = os.path.dirname(roadrunner_directory)

# add local site-packages dir to path for running tests
# without installing roadrunner.
sys.path.append(rr_site_packages_dir)

# some debugging messages
print(f"Executing __main__.py located at \"{__file__}\"")
print("Adding roadrunner site-packages to sys.path: ", rr_site_packages_dir)

import roadrunner
import test_rrtests
roadrunner.Config.setValue(roadrunner.Config.LLVM_BACKEND, roadrunner.Config.LLJIT)
print(f"Using roadrunner at {os.path.abspath(roadrunner.__file__)}")
print(f"Running test_rrtests at {os.path.abspath(test_rrtests.__file__)}")

roadrunner.sigtrap()

test_rrtests.testAllRRTestFiles(test_data_dir)







