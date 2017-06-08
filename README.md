# IFTTT-FastttCamera-Xamarin-Binding
IFTTT-FastttCamera Xamarin.iOS Binding


```
Install-Package DreamAR.Inc.FastttCamera.iOS
```

## To update binding
- Download the source code from the appropriate release
- Run pod for a sample
- Open the sample then add a new Aggregate target
- Use fat-lib.sh content as a new `RunScript`
- Change new Scheme to `Release` then *BUILD*

## Verify if binding needs to be updated
- Copy .a file and .h files to frameworks/FastttCamera folder
- Run `generate-binding.sh` script
- Check `git` if there are any changes with binding definitions
- If not, just build the solution to get the latest version update and runing
- If there are updates, see git changes to find out where to update in ApiDefintions in project DreamAR.Inc.FastttCamera.iOS
